using System;
using System.Collections.Concurrent;
using LmpClient.Base;
using LmpClient.Base.Interface;
using LmpClient.Network;
using LmpClient.Systems.SettingsSys;
using LmpClient.Systems.Mod;
using LmpClient.Systems.TimeSync;
using LmpCommon.Enums;
using LmpCommon.Message.Data.Time;
using LmpCommon.Message.Interface;
using LmpCommon.Message.Types;
using LmpCommon.ModFile;
using LmpCommon.Time;

namespace LmpClient.Systems.NetworkTime
{
    public class NetworkTimeMessageHandler : SubSystem<NetworkTimeSystem>, IMessageHandler
    {
        public ConcurrentQueue<IServerMessageBase> IncomingMessages { get; set; } = new ConcurrentQueue<IServerMessageBase>();
        //Averaging ring buffers
        private const int NETWORK_TIME_VALID = 4;
        private const int NETWORK_TIME_AVERAGE = 10;
        private bool offsetFull = false;
        private int offsetPos = 0;
        private long[] offsets = new long[NETWORK_TIME_AVERAGE];
        private bool latencyFull = false;
        private int latencyPos = 0;
        private long[] latencys = new long[NETWORK_TIME_AVERAGE];
        //Public get, use for debugging maybe?
        public long offset { private set; get; }
        public long latency { private set; get; }

        public void HandleMessage(IServerMessageBase msg)
        {
            if (!(msg.Data is NetworkTimeBaseMsgData msgData)) return;

            switch (msgData.NetworkTimeMessageType)
            {
                case NetworkTimeMessageType.Reply:
                    HandleNetworkTimeReplyReceivedMessage((NetworkTimeReplyMsgData)msgData);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        #region Private

        public void HandleNetworkTimeReplyReceivedMessage(NetworkTimeReplyMsgData data)
        {
            long receiveTime = DateTime.UtcNow.Ticks;
            long thisLatency = receiveTime - data.SendTime;
            //The server time upon receiving this message should be the server time it told us plus half of our latency.
            //Positive means we are faster than server clock.
            long thisOffset = receiveTime - (data.ServerTime + (thisLatency / 2));

            //Add to ring buffers
            offsets[offsetPos] = thisOffset;
            offsetPos++;
            if (offsetPos >= offsets.Length)
            {
                offsetFull = true;
                offsetPos = 0;
            }

            latencys[latencyPos] = thisLatency;
            latencyPos++;
            if (latencyPos >= latencys.Length)
            {
                latencyFull = true;
                latencyPos = 0;
            }

            //Average
            int latencyEnd = latencyPos;
            if (latencyFull)
            {
                latencyEnd = latencys.Length;
            }
            int offsetEnd = offsetPos;
            if (offsetFull)
            {
                offsetEnd = offsets.Length;
            }
            long latencyTotal = 0;
            for (int i = 0; i < latencyEnd; i++)
            {
                latencyTotal += latencys[i];
            }
            long offsetTotal = 0;
            for (int i = 0; i < offsetEnd; i++)
            {
                offsetTotal += offsets[i];
            }
            offset = offsetTotal / offsetEnd;
            latency = latencyTotal / latencyEnd;

            //LunaLog.Log("NetworkTime offset update: " + Math.Round((double)(offset / TimeSpan.TicksPerMillisecond), 2) + "ms");
            //LunaLog.Log("NetworkTime latency update: " + Math.Round((double)(latency / TimeSpan.TicksPerMillisecond), 2) + "ms");
            LunaNetworkTime.TimeDifference = TimeSpan.FromTicks(offset);
            if (MainSystem.NetworkState == ClientState.NetworkTime)
            {
                if (offsetPos >= NETWORK_TIME_VALID || offsetFull)
                {
                    MainSystem.NetworkState = ClientState.NetworkTimeSynced;
                }
                else
                {
                    NetworkTimeSystem.Singleton.MessageSender.SendNetworkTimeRequest();
                }
            }
        }

        #endregion
    }
}

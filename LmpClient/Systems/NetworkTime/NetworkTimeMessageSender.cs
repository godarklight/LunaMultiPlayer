using System;
using LmpClient.Base;
using LmpClient.Base.Interface;
using LmpClient.Network;
using LmpCommon.Message.Client;
using LmpCommon.Message.Data.Time;
using LmpCommon.Message.Interface;

namespace LmpClient.Systems.NetworkTime
{
    public class NetworkTimeMessageSender : SubSystem<NetworkTimeSystem>, IMessageSender
    {
        public void SendMessage(IMessageData msg)
        {
            TaskFactory.StartNew(() => NetworkSender.QueueOutgoingMessage(MessageFactory.CreateNew<NetworkTimeCliMsg>(msg)));
        }

        public void SendNetworkTimeRequest()
        {
            var msgData = NetworkMain.CliMsgFactory.CreateNewMessageData<NetworkTimeRequestMsgData>();
            msgData.SendTime = DateTime.UtcNow.Ticks;

            SendMessage(msgData);
        }
    }
}

using System;
using LmpCommon.Enums;
using LmpCommon.Message.Data.Time;
using LmpCommon.Message.Data.PlayerConnection;
using LmpCommon.Message.Server;
using Server.Client;
using Server.Context;
using Server.Log;
using Server.Plugin;
using Server.Server;

namespace Server.System
{
    public class NetworkTimeSystem
    {
        public void HandleTimeRequest(ClientStructure client, NetworkTimeRequestMsgData data)
        {
            var msgData = ServerContext.ServerMessageFactory.CreateNewMessageData<NetworkTimeReplyMsgData>();
            msgData.SendTime = data.SendTime;
            msgData.ServerTime = DateTime.UtcNow.Ticks;
            MessageQueuer.SendToClient<NetworkTimeSrvMsg>(client, msgData);
        }
    }
}

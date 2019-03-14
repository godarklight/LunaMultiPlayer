using System;
using LmpCommon.Message.Data.Time;
using LmpCommon.Message.Interface;
using LmpCommon.Message.Types;
using Server.Client;
using Server.Message.Base;
using Server.System;

namespace Server.Message
{
    public class NetworkTimeMsgReader : ReaderBase
    {
        private static readonly NetworkTimeSystem TimeHandler = new NetworkTimeSystem();

        public override void HandleMessage(ClientStructure client, IClientMessageBase message)
        {
            var data = message.Data as NetworkTimeBaseMsgData;
            switch (data?.NetworkTimeMessageType)
            {
                case NetworkTimeMessageType.Request:
                    TimeHandler.HandleTimeRequest(client, (NetworkTimeRequestMsgData)data);
                    break;
                default:
                    throw new NotImplementedException("Time type not implemented");
            }
            
            message.Recycle();
        }
    }
}

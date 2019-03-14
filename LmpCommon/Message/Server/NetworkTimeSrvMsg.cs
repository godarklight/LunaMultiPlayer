using Lidgren.Network;
using LmpCommon.Enums;
using LmpCommon.Message.Data.Time;
using LmpCommon.Message.Server.Base;
using LmpCommon.Message.Types;
using System;
using System.Collections.Generic;

namespace LmpCommon.Message.Server
{
    public class NetworkTimeSrvMsg : SrvMsgBase<NetworkTimeBaseMsgData>
    {
        /// <inheritdoc />
        internal NetworkTimeSrvMsg() { }

        /// <inheritdoc />
        public override string ClassName { get; } = nameof(NetworkTimeSrvMsg);

        /// <inheritdoc />
        protected override Dictionary<ushort, Type> SubTypeDictionary { get; } = new Dictionary<ushort, Type>
        {
            [(ushort)NetworkTimeMessageType.Reply] = typeof(NetworkTimeReplyMsgData)
        };

        public override ServerMessageType MessageType => ServerMessageType.NetworkTime;

        protected override int DefaultChannel => 1;

        public override NetDeliveryMethod NetDeliveryMethod => NetDeliveryMethod.Unreliable;
    }
}

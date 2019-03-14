using Lidgren.Network;
using LmpCommon.Enums;
using LmpCommon.Message.Client.Base;
using LmpCommon.Message.Data.Time;
using LmpCommon.Message.Types;
using System;
using System.Collections.Generic;

namespace LmpCommon.Message.Client
{
    public class NetworkTimeCliMsg : CliMsgBase<NetworkTimeBaseMsgData>
    {
        /// <inheritdoc />
        internal NetworkTimeCliMsg() { }

        /// <inheritdoc />
        public override string ClassName { get; } = nameof(NetworkTimeCliMsg);

        /// <inheritdoc />
        protected override Dictionary<ushort, Type> SubTypeDictionary { get; } = new Dictionary<ushort, Type>
        {
            [(ushort)NetworkTimeMessageType.Request] = typeof(NetworkTimeRequestMsgData)
        };

        public override ClientMessageType MessageType => ClientMessageType.NetworkTime;

        protected override int DefaultChannel => 1;

        public override NetDeliveryMethod NetDeliveryMethod => NetDeliveryMethod.Unreliable;
    }
}

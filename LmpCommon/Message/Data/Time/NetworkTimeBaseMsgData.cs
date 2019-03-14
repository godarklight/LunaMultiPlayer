using Lidgren.Network;
using LmpCommon.Message.Base;
using LmpCommon.Message.Types;
using System;

namespace LmpCommon.Message.Data.Time
{
    public abstract class NetworkTimeBaseMsgData : MessageData
    {
        /// <inheritdoc />
        internal NetworkTimeBaseMsgData() { }
        public override ushort SubType => (ushort)(int)NetworkTimeMessageType;

        public virtual NetworkTimeMessageType NetworkTimeMessageType => throw new NotImplementedException();

        internal override void InternalSerialize(NetOutgoingMessage lidgrenMsg)
        {
            //Nothing to implement here
        }

        internal override void InternalDeserialize(NetIncomingMessage lidgrenMsg)
        {
            //Nothing to implement here
        }

        internal override int InternalGetMessageSize()
        {
            return 0;
        }
    }
}

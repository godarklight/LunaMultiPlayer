using Lidgren.Network;
using LmpCommon.Message.Base;
using LmpCommon.Message.Types;

namespace LmpCommon.Message.Data.Time
{
    public class NetworkTimeRequestMsgData : NetworkTimeBaseMsgData
    {
        /// <inheritdoc />
        internal NetworkTimeRequestMsgData() { }
        public override NetworkTimeMessageType NetworkTimeMessageType => NetworkTimeMessageType.Request;

        public long SendTime;

        public override string ClassName { get; } = nameof(NetworkTimeRequestMsgData);

        internal override void InternalSerialize(NetOutgoingMessage lidgrenMsg)
        {
            base.InternalSerialize(lidgrenMsg);
            lidgrenMsg.Write(SendTime);
        }

        internal override void InternalDeserialize(NetIncomingMessage lidgrenMsg)
        {
            base.InternalDeserialize(lidgrenMsg);
            SendTime = lidgrenMsg.ReadInt64();
        }

        internal override int InternalGetMessageSize()
        {
            return base.InternalGetMessageSize() + sizeof(long);
        }
    }
}

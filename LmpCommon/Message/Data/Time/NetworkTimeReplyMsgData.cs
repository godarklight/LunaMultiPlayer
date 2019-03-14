using Lidgren.Network;
using LmpCommon.Enums;
using LmpCommon.Message.Base;
using LmpCommon.Message.Types;

namespace LmpCommon.Message.Data.Time
{
    public class NetworkTimeReplyMsgData : NetworkTimeBaseMsgData
    {
        /// <inheritdoc />
        internal NetworkTimeReplyMsgData() { }
        public override NetworkTimeMessageType NetworkTimeMessageType => NetworkTimeMessageType.Reply;

        public long SendTime;
        public long ServerTime;

        public override string ClassName { get; } = nameof(NetworkTimeReplyMsgData);

        internal override void InternalSerialize(NetOutgoingMessage lidgrenMsg)
        {
            base.InternalSerialize(lidgrenMsg);
            lidgrenMsg.Write(SendTime);
            lidgrenMsg.Write(ServerTime);
        }

        internal override void InternalDeserialize(NetIncomingMessage lidgrenMsg)
        {
            base.InternalDeserialize(lidgrenMsg);
            SendTime = lidgrenMsg.ReadInt64();
            ServerTime = lidgrenMsg.ReadInt64();
        }
        
        internal override int InternalGetMessageSize()
        {
            return base.InternalGetMessageSize() + sizeof(long) * 2;
        }
    }
}

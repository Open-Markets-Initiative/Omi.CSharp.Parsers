using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Delete Order Message: Upon receipt of this message, client should remove the order from its local book.
    /// </summary>

    public partial class DeleteOrderMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MarketId MarketId;
            public OrderId OrderId;
            public MessageDateTime MessageDateTime;
            public SequenceWithinMillis SequenceWithinMillis;
            public RequestTradingEngineReceivedTimestamp RequestTradingEngineReceivedTimestamp;
        };
    };
}
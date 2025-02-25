using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Market Snapshot Order Message: This message is for orders in snapshot only. It is different from the order message for incremental updates.
    /// </summary>

    public partial class MarketSnapshotOrderMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MarketId MarketId;
            public OrderId OrderId;
            public OrderSequenceId OrderSequenceId;
            public Side Side;
            public Price Price;
            public Quantity Quantity;
            public IsImplied IsImplied;
            public IsRfq IsRfq;
            public OrderEntryDateTime OrderEntryDateTime;
            public SequenceWithinMillis SequenceWithinMillis;
        };
    };
}
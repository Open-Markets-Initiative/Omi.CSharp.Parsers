using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Market Snapshot Order Message
    /// </summary>

    public partial class MarketSnapshotOrderMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            OrderId OrderId;
            OrderSequenceId OrderSequenceId;
            Side Side;
            Price Price;
            Quantity Quantity;
            IsImplied IsImplied;
            IsRfq IsRfq;
            OrderEntryDateTime OrderEntryDateTime;
            SequenceWithinMillis SequenceWithinMillis;
        };
    };
}
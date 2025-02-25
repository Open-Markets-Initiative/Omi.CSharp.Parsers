using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Add Or Modify Order Message: Client should add the order to book if it is not there already. Otherwise, just overwrite the existing order.
    /// </summary>

    public partial class AddOrModifyOrderMessage
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
            public ExtraFlags ExtraFlags;
            public SequenceWithinMillis SequenceWithinMillis;
            public ModificationTimestamp ModificationTimestamp;
            public RequestTradingEngineReceivedTimestamp RequestTradingEngineReceivedTimestamp;
        };
    };
}
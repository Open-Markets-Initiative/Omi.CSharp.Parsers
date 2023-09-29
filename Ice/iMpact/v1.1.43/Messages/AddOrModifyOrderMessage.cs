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
            MarketId MarketId;
            OrderId OrderId;
            OrderSequenceId OrderSequenceId;
            Side Side;
            Price Price;
            Quantity Quantity;
            IsImplied IsImplied;
            IsRfq IsRfq;
            OrderEntryDateTime OrderEntryDateTime;
            ExtraFlags ExtraFlags;
            SequenceWithinMillis SequenceWithinMillis;
            ModificationTimestamp ModificationTimestamp;
            RequestTradingEngineReceivedTimestamp RequestTradingEngineReceivedTimestamp;
        };
    };
}
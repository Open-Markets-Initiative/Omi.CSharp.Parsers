using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Add Or Modify Order Message
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
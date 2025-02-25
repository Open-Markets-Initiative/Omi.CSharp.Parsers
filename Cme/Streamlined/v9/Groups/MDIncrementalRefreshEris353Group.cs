using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  M D Incremental Refresh Eris 353 Group: Number of entries in Market Data message.
    /// </summary>

    public partial class MDIncrementalRefreshEris353Group
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MdUpdateActionChar MdUpdateActionChar;
            public MdEntryType MdEntryType;
            public RptSeq RptSeq;
            public MdEntryPxDecimal MdEntryPxDecimal;
            public MdEntrySizeOptional MdEntrySizeOptional;
            public CalFutPx CalFutPx;
            public MdEntryPositionNo MdEntryPositionNo;
            public NumberOfOrders NumberOfOrders;
            public TradeId TradeId;
            public AggressorSide AggressorSide;
            public Symbol Symbol;
            public SecurityGroup26 SecurityGroup26;
            public SecurityType SecurityType;
            public SecurityExchange SecurityExchange;
            public ProductOptional ProductOptional;
            public MaturityDate MaturityDate;
            public ReferenceId50 ReferenceId50;
            public MdQuoteType MdQuoteType;
        };
    };
}
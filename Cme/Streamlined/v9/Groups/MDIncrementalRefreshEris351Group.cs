using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  M D Incremental Refresh Eris 351 Group: Number of entries in Market Data message.
    /// </summary>

    public partial class MDIncrementalRefreshEris351Group
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MdUpdateActionChar MdUpdateActionChar;
            MdEntryType MdEntryType;
            RptSeq RptSeq;
            MdEntryPxDecimal MdEntryPxDecimal;
            MdEntrySizeOptional MdEntrySizeOptional;
            CalFutPx CalFutPx;
            MdEntryPositionNo MdEntryPositionNo;
            NumberOfOrders NumberOfOrders;
            TradeId TradeId;
            AggressorSide AggressorSide;
            Symbol Symbol;
            SecurityGroup26 SecurityGroup26;
            SecurityType SecurityType;
            SecurityExchange SecurityExchange;
            ProductOptional ProductOptional;
            MaturityDate MaturityDate;
            ReferenceId50 ReferenceId50;
        };
    };
}
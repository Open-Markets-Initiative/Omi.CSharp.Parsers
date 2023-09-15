using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Snapshot Full Refresh Long Qty: SnapshotFullRefreshLongQty
    /// </summary>

    public partial class SnapshotFullRefreshLongQty
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            LastMsgSeqNumProcessed LastMsgSeqNumProcessed;
            TotNumReports TotNumReports;
            SecurityId SecurityId;
            RptSeq RptSeq;
            TransactTime TransactTime;
            LastUpdateTime LastUpdateTime;
            TradeDate TradeDate;
            MdSecurityTradingStatus MdSecurityTradingStatus;
            HighLimitPrice HighLimitPrice;
            LowLimitPrice LowLimitPrice;
            MaxPriceVariation MaxPriceVariation;
        };
    };
}
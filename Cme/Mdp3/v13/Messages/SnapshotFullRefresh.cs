using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Snapshot Full Refresh: SnapshotFullRefresh
    /// </summary>

    public partial class SnapshotFullRefresh
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
using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Snapshot Full Refresh Long Qty: SnapshotFullRefreshLongQty
/// </summary>

public partial class SnapshotFullRefreshLongQty
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public LastMsgSeqNumProcessed LastMsgSeqNumProcessed;
        public TotNumReports TotNumReports;
        public SecurityId SecurityId;
        public RptSeq RptSeq;
        public TransactTime TransactTime;
        public LastUpdateTime LastUpdateTime;
        public TradeDate TradeDate;
        public MdSecurityTradingStatus MdSecurityTradingStatus;
        public HighLimitPrice HighLimitPrice;
        public LowLimitPrice LowLimitPrice;
        public MaxPriceVariation MaxPriceVariation;
    };
};

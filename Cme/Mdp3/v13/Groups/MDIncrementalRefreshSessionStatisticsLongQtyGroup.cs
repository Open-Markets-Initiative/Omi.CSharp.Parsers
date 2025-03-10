using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  M D Incremental Refresh Session Statistics Long Qty Group: Number of entries in Market Data message
/// </summary>

public partial class MDIncrementalRefreshSessionStatisticsLongQtyGroup
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MdEntryPx MdEntryPx;
        public MdEntrySizeUInt64Null MdEntrySizeUInt64Null;
        public SecurityId SecurityId;
        public RptSeq RptSeq;
        public OpenCloseSettlFlag OpenCloseSettlFlag;
        public MdUpdateAction MdUpdateAction;
        public MdEntryTypeStatistics MdEntryTypeStatistics;
        public Padding5 Padding5;
    };
};

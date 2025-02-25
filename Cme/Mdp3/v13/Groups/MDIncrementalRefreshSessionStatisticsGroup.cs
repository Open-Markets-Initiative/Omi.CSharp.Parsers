using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  M D Incremental Refresh Session Statistics Group: Number of entries in Market Data message
    /// </summary>

    public partial class MDIncrementalRefreshSessionStatisticsGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MdEntryPx MdEntryPx;
            public SecurityId SecurityId;
            public RptSeq RptSeq;
            public OpenCloseSettlFlag OpenCloseSettlFlag;
            public MdUpdateAction MdUpdateAction;
            public MdEntryTypeStatistics MdEntryTypeStatistics;
            public MdEntrySizeOptional MdEntrySizeOptional;
            public Padding1 Padding1;
        };
    };
}
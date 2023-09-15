using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  M D Incremental Refresh Session Statistics Group: Number of entries in Market Data message
    /// </summary>

    public partial class MDIncrementalRefreshSessionStatisticsGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MdEntryPx MdEntryPx;
            SecurityId SecurityId;
            RptSeq RptSeq;
            OpenCloseSettlFlag OpenCloseSettlFlag;
            MdUpdateAction MdUpdateAction;
            MdEntryTypeStatistics MdEntryTypeStatistics;
            MdEntrySizeOptional MdEntrySizeOptional;
            Padding1 Padding1;
        };
    };
}
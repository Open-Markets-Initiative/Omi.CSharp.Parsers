using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  M D Incremental Refresh Session Statistics Long Qty Group: Number of entries in Market Data message
    /// </summary>

    public partial class MDIncrementalRefreshSessionStatisticsLongQtyGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MdEntryPx MdEntryPx;
            MdEntrySizeUInt64Null MdEntrySizeUInt64Null;
            SecurityId SecurityId;
            RptSeq RptSeq;
            OpenCloseSettlFlag OpenCloseSettlFlag;
            MdUpdateAction MdUpdateAction;
            MdEntryTypeStatistics MdEntryTypeStatistics;
            Padding5 Padding5;
        };
    };
}
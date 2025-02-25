using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  M D Incremental Refresh Trade Summary Group: Number of Trade Summary entries
    /// </summary>

    public partial class MDIncrementalRefreshTradeSummaryGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MdEntryPx MdEntryPx;
            public MdEntrySize MdEntrySize;
            public SecurityId SecurityId;
            public RptSeq RptSeq;
            public NumberOfOrders NumberOfOrders;
            public AggressorSide AggressorSide;
            public MdUpdateAction MdUpdateAction;
            public MdTradeEntryIDUInt32Null MdTradeEntryIDUInt32Null;
            public Padding2 Padding2;
        };
    };
}
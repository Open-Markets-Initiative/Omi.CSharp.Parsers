using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  M D Incremental Refresh Trade Summary Group: Number of Trade Summary entries
    /// </summary>

    public partial class MDIncrementalRefreshTradeSummaryGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MdEntryPx MdEntryPx;
            MdEntrySize MdEntrySize;
            SecurityId SecurityId;
            RptSeq RptSeq;
            NumberOfOrders NumberOfOrders;
            AggressorSide AggressorSide;
            MdUpdateAction MdUpdateAction;
            MdTradeEntryIDUInt32Null MdTradeEntryIDUInt32Null;
            Padding2 Padding2;
        };
    };
}
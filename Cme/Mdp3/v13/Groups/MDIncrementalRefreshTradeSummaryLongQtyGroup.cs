using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  M D Incremental Refresh Trade Summary Long Qty Group: Number of Trade Summary entries
    /// </summary>

    public partial class MDIncrementalRefreshTradeSummaryLongQtyGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MdEntryPx MdEntryPx;
            MdEntrySizeUInt64 MdEntrySizeUInt64;
            SecurityId SecurityId;
            RptSeq RptSeq;
            NumberOfOrders NumberOfOrders;
            MdTradeEntryIDUInt32 MdTradeEntryIDUInt32;
            AggressorSide AggressorSide;
            MdUpdateAction MdUpdateAction;
            Padding6 Padding6;
        };
    };
}
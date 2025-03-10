using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  M D Incremental Refresh Trade Summary Long Qty Group: Number of Trade Summary entries
/// </summary>

public partial class MDIncrementalRefreshTradeSummaryLongQtyGroup
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MdEntryPx MdEntryPx;
        public MdEntrySizeUInt64 MdEntrySizeUInt64;
        public SecurityId SecurityId;
        public RptSeq RptSeq;
        public NumberOfOrders NumberOfOrders;
        public MdTradeEntryIDUInt32 MdTradeEntryIDUInt32;
        public AggressorSide AggressorSide;
        public MdUpdateAction MdUpdateAction;
        public Padding6 Padding6;
    };
};

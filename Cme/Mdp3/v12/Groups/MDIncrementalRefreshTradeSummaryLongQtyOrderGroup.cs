using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  M D Incremental Refresh Trade Summary Long Qty Order Group: Number of OrderID and LastQty entries in Trade Summary message
/// </summary>

public partial class MDIncrementalRefreshTradeSummaryLongQtyOrderGroup
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public OrderId OrderId;
        public LastQty LastQty;
        public Padding4 Padding4;
    };
};

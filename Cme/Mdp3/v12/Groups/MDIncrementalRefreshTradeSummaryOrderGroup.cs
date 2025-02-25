using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  M D Incremental Refresh Trade Summary Order Group: Number of OrderID entries
    /// </summary>

    public partial class MDIncrementalRefreshTradeSummaryOrderGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public OrderId OrderId;
            public LastQty LastQty;
            public Padding4 Padding4;
        };
    };
}
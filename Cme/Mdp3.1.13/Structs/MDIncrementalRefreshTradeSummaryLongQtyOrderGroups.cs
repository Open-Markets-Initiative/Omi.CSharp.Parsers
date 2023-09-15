using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  M D Incremental Refresh Trade Summary Long Qty Order Groups: Number of OrderID and LastQty entries in Trade Summary message Block
    /// </summary>

    public partial class MDIncrementalRefreshTradeSummaryLongQtyOrderGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize8Byte GroupSize8Byte;
        };
    };
}
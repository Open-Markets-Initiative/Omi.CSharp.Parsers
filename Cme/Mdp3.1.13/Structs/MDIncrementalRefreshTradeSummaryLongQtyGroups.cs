using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  M D Incremental Refresh Trade Summary Long Qty Groups: Number of Trade Summary entries Block
    /// </summary>

    public partial class MDIncrementalRefreshTradeSummaryLongQtyGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}
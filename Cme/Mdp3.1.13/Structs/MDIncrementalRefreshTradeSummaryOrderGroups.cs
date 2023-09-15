using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  M D Incremental Refresh Trade Summary Order Groups: Number of OrderID entries Block
    /// </summary>

    public partial class MDIncrementalRefreshTradeSummaryOrderGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize8Byte GroupSize8Byte;
        };
    };
}
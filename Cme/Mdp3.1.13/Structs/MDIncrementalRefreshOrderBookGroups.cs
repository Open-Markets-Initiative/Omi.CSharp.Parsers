using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  M D Incremental Refresh Order Book Groups: Number of entries in Market Data message Block
    /// </summary>

    public partial class MDIncrementalRefreshOrderBookGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}
using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  M D Incremental Refresh Indices Groups: Number of entries in Market Data message Block
    /// </summary>

    public partial class MDIncrementalRefreshIndicesGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}
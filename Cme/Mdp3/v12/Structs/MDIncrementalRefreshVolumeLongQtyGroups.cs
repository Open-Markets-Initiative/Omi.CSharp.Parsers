using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  M D Incremental Refresh Volume Long Qty Groups: Number of entries in Market Data message Block
    /// </summary>

    public partial class MDIncrementalRefreshVolumeLongQtyGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}
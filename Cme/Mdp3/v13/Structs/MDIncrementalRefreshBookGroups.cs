using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  M D Incremental Refresh Book Groups: Number of entries in Market Data message Block
    /// </summary>

    public partial class MDIncrementalRefreshBookGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}
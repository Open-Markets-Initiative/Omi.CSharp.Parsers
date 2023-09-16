using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  M D Incremental Refresh Session Statistics Groups: Number of entries in Market Data message Block
    /// </summary>

    public partial class MDIncrementalRefreshSessionStatisticsGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}
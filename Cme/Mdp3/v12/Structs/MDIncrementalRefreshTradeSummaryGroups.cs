using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  M D Incremental Refresh Trade Summary Groups: Number of Trade Summary entries Block
    /// </summary>

    public partial class MDIncrementalRefreshTradeSummaryGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}
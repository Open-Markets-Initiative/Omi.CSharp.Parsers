using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Incremental Refresh Trade Summary: MDIncrementalRefreshTradeSummary
    /// </summary>

    public partial class MdIncrementalRefreshTradeSummary
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            TransactTime TransactTime;
            MatchEventIndicator MatchEventIndicator;
            Padding2 Padding2;
        };
    };
}
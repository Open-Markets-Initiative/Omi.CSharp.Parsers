using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Incremental Refresh Limits Banding: MDIncrementalRefreshLimitsBanding
    /// </summary>

    public partial class MdIncrementalRefreshLimitsBanding
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
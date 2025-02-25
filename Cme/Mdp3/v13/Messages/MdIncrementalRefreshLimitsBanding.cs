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
            public TransactTime TransactTime;
            public MatchEventIndicator MatchEventIndicator;
            public Padding2 Padding2;
        };
    };
}
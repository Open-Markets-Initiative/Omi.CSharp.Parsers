using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Md Incremental Refresh Session Statistics: MDIncrementalRefreshSessionStatistics
/// </summary>

public partial class MdIncrementalRefreshSessionStatistics
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public TransactTime TransactTime;
        public MatchEventIndicator MatchEventIndicator;
        public Padding2 Padding2;
    };
};

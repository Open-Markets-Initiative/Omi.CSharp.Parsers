using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Md Incremental Refresh Volume: MDIncrementalRefreshVolume
/// </summary>

public partial class MdIncrementalRefreshVolume
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public TransactTime TransactTime;
        public MatchEventIndicator MatchEventIndicator;
        public Padding2 Padding2;
    };
};

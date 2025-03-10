using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Md Incremental Refresh Book: MDIncrementalRefreshBook
/// </summary>

public partial class MdIncrementalRefreshBook
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public TransactTime TransactTime;
        public MatchEventIndicator MatchEventIndicator;
        public Padding2 Padding2;
    };
};

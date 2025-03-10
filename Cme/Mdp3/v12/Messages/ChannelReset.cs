using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Channel Reset: ChannelReset
/// </summary>

public partial class ChannelReset
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public TransactTime TransactTime;
        public MatchEventIndicator MatchEventIndicator;
    };
};

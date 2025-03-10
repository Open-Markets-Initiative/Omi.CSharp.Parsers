using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Channel Reset Group: Number of entries in Market Data message
/// </summary>

public partial class ChannelResetGroup
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public ApplId ApplId;
    };
};

using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Channel Reset Groups: Number of entries in Market Data message Block
    /// </summary>

    public partial class ChannelResetGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}
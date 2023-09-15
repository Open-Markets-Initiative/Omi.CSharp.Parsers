using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Channel Reset: ChannelReset
    /// </summary>

    public partial class ChannelReset
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            TransactTime TransactTime;
            MatchEventIndicator MatchEventIndicator;
        };
    };
}
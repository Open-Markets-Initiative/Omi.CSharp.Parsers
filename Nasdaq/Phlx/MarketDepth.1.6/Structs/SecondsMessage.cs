using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Seconds Message: This message is sent every second for which at least one PHLX Depth message is being generated.
    /// </summary>

    public partial class SecondsMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Second Second;
        };
    };
}
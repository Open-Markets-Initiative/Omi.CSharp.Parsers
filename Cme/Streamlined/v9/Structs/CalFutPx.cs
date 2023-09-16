using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Cal Fut Px: Number of entries in Market Data message.
    /// </summary>

    public partial class CalFutPx
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Mantissa Mantissa;
            Exponent Exponent;
        };
    };
}
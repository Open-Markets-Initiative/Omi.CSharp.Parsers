using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Cal Fut Px Optional: Number of entries in Market Data message.
    /// </summary>

    public partial class CalFutPxOptional
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Mantissa Mantissa;
            Exponent Exponent;
        };
    };
}
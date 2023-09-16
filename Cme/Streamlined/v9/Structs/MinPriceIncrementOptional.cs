using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Min Price Increment Optional: Number of entries in Market Data message.
    /// </summary>

    public partial class MinPriceIncrementOptional
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Mantissa Mantissa;
            Exponent Exponent;
        };
    };
}
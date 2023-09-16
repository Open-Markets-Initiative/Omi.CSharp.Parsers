using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Strike Price Decimal: Number of entries in Market Data message.
    /// </summary>

    public partial class StrikePriceDecimal
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Mantissa Mantissa;
            Exponent Exponent;
        };
    };
}
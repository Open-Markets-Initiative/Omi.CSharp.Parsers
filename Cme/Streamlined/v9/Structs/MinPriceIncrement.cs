using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Min Price Increment: MDInstrumentDefinitionEris
    /// </summary>

    public partial class MinPriceIncrement
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Mantissa Mantissa;
            Exponent Exponent;
        };
    };
}
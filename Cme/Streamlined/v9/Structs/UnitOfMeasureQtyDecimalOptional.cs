using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Unit Of Measure Qty Decimal Optional: Number of entries in Market Data message.
    /// </summary>

    public partial class UnitOfMeasureQtyDecimalOptional
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Mantissa Mantissa;
            Exponent Exponent;
        };
    };
}
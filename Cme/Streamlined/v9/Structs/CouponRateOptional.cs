using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Coupon Rate Optional: Number of entries in Market Data message.
    /// </summary>

    public partial class CouponRateOptional
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Mantissa32 Mantissa32;
            Exponent Exponent;
        };
    };
}
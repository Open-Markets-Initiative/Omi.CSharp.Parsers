using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Fair Coupon Pct: Number of entries in Market Data message.
    /// </summary>

    public partial class FairCouponPct
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Mantissa Mantissa;
            Exponent Exponent;
        };
    };
}
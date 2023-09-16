using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Coupon Rate: 4 Byte Fixed Width Nullable Integer with 4 Decimal Place Precision
    /// </summary>

    public struct CouponRate
    {
        /// <summary>
        ///  Fix Tag for Coupon Rate
        /// </summary>
        public const ushort FixTag = 223;

        /// <summary>
        ///  Length of Coupon Rate in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Decimal place factor for Coupon Rate
        /// </summary>
        public const int Factor = 10000;

        /// <summary>
        ///  Null value for Coupon Rate
        /// </summary>
        public const int NoValue = 2147483647;
    }
}
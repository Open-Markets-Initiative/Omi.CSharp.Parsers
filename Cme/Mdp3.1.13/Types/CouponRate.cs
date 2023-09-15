namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Coupon Rate: 8 Byte Fixed Width Nullable Integer with 9 Decimal Place Precision
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
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Coupon Rate
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Null value for Coupon Rate
        /// </summary>
        public const long NoValue = 9223372036854775807;
    }
}
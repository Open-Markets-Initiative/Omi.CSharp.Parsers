using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Coupon Frequency Period: Optional 2 Byte Fixed Width Integer
    /// </summary>

    public struct CouponFrequencyPeriod
    {
        /// <summary>
        ///  Length of Coupon Frequency Period in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Null value for Coupon Frequency Period
        /// </summary>
        public const ushort NoValue = 65535;
    }
}
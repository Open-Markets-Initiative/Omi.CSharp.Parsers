using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Alt Min Price Increment: 8 Byte Fixed Width Nullable Integer with 9 Decimal Place Precision
    /// </summary>

    public struct AltMinPriceIncrement
    {
        /// <summary>
        ///  Fix Tag for Alt Min Price Increment
        /// </summary>
        public const ushort FixTag = 37739;

        /// <summary>
        ///  Length of Alt Min Price Increment in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Alt Min Price Increment
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Null value for Alt Min Price Increment
        /// </summary>
        public const long NoValue = 9223372036854775807;
    }
}
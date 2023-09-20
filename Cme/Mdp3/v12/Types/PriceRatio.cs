using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Price Ratio: 8 Byte Fixed Width Nullable Integer with 9 Decimal Place Precision
    /// </summary>

    public struct PriceRatio
    {
        /// <summary>
        ///  Fix Tag for Price Ratio
        /// </summary>
        public const ushort FixTag = 5770;

        /// <summary>
        ///  Length of Price Ratio in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Price Ratio
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Null value for Price Ratio
        /// </summary>
        public const long NoValue = 9223372036854775807;
    }
}
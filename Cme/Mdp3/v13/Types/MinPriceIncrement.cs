using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Min Price Increment: 8 Byte Fixed Width Integer with 9 Decimal Place Precision
    /// </summary>

    public struct MinPriceIncrement
    {
        /// <summary>
        ///  Fix Tag for Min Price Increment
        /// </summary>
        public const ushort FixTag = 969;

        /// <summary>
        ///  Length of Min Price Increment in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Min Price Increment
        /// </summary>
        public const int Factor = 1000000000;
    }
}
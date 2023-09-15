namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Min Price Increment Amount: 8 Byte Fixed Width Nullable Integer with 9 Decimal Place Precision
    /// </summary>

    public struct MinPriceIncrementAmount
    {
        /// <summary>
        ///  Fix Tag for Min Price Increment Amount
        /// </summary>
        public const ushort FixTag = 1146;

        /// <summary>
        ///  Length of Min Price Increment Amount in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Min Price Increment Amount
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Null value for Min Price Increment Amount
        /// </summary>
        public const long NoValue = 9223372036854775807;
    }
}
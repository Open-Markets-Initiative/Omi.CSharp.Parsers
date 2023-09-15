namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Max Price Variation: 8 Byte Fixed Width Nullable Integer with 9 Decimal Place Precision
    /// </summary>

    public struct MaxPriceVariation
    {
        /// <summary>
        ///  Fix Tag for Max Price Variation
        /// </summary>
        public const ushort FixTag = 1143;

        /// <summary>
        ///  Length of Max Price Variation in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Max Price Variation
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Null value for Max Price Variation
        /// </summary>
        public const long NoValue = 9223372036854775807;
    }
}
namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Max Price Discretion Offset: 8 Byte Fixed Width Integer with 9 Decimal Place Precision
    /// </summary>

    public struct MaxPriceDiscretionOffset
    {
        /// <summary>
        ///  Fix Tag for Max Price Discretion Offset
        /// </summary>
        public const ushort FixTag = 37728;

        /// <summary>
        ///  Length of Max Price Discretion Offset in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Max Price Discretion Offset
        /// </summary>
        public const int Factor = 1000000000;
    }
}
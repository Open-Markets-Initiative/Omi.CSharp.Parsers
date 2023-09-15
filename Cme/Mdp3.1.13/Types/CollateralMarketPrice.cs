namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Collateral Market Price: 8 Byte Fixed Width Integer with 9 Decimal Place Precision
    /// </summary>

    public struct CollateralMarketPrice
    {
        /// <summary>
        ///  Fix Tag for Collateral Market Price
        /// </summary>
        public const ushort FixTag = 2689;

        /// <summary>
        ///  Length of Collateral Market Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Collateral Market Price
        /// </summary>
        public const int Factor = 1000000000;
    }
}
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Explicit Strike Price: 4 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public struct ExplicitStrikePrice
    {
        /// <summary>
        ///  Length of Explicit Strike Price in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Decimal place factor for Explicit Strike Price
        /// </summary>
        public const int Factor = 10000;
    }
}
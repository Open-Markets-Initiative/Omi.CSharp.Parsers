using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Short Price: 2 Byte Fixed Width Integer with 2 Decimal Place Precision
    /// </summary>

    public struct ShortPrice
    {
        /// <summary>
        ///  Length of Short Price in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Decimal place factor for Short Price
        /// </summary>
        public const int Factor = 100;
    }
}
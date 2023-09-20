using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Price: 4 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public struct Price
    {
        /// <summary>
        ///  Length of Price in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Decimal place factor for Price
        /// </summary>
        public const int Factor = 10000;
    }
}
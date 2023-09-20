using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Ask Price: 4 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public struct AskPrice
    {
        /// <summary>
        ///  Length of Ask Price in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Decimal place factor for Ask Price
        /// </summary>
        public const int Factor = 10000;
    }
}
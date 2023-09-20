using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Short Bid Price: 2 Byte Fixed Width Integer with 2 Decimal Place Precision
    /// </summary>

    public struct ShortBidPrice
    {
        /// <summary>
        ///  Length of Short Bid Price in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Decimal place factor for Short Bid Price
        /// </summary>
        public const int Factor = 100;
    }
}
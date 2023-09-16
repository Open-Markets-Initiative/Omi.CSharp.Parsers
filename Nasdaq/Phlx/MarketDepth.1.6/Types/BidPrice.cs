using System.Runtime.CompilerServices;;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Bid Price: 4 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public struct BidPrice
    {
        /// <summary>
        ///  Length of Bid Price in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Decimal place factor for Bid Price
        /// </summary>
        public const int Factor = 10000;
    }
}
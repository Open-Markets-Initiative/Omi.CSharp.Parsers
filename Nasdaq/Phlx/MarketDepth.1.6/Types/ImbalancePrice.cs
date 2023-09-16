using System.Runtime.CompilerServices;;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Imbalance Price: 4 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public struct ImbalancePrice
    {
        /// <summary>
        ///  Length of Imbalance Price in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Decimal place factor for Imbalance Price
        /// </summary>
        public const int Factor = 10000;
    }
}
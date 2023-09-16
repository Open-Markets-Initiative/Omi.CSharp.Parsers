using System.Runtime.CompilerServices;;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Imbalance Direction
    /// </summary>

    public struct ImbalanceDirection
    {
        /// <summary>
        ///  Buy Imbalance
        /// </summary>
        public const char Buy = 'B';

        /// <summary>
        ///  Sell Imbalance
        /// </summary>
        public const char Sell = 'S';

        /// <summary>
        ///  Length of Imbalance Direction in bytes
        /// </summary>
        public const int Length = 1;
    }
}
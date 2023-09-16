using System.Runtime.CompilerServices;;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Market Side
    /// </summary>

    public struct MarketSide
    {
        /// <summary>
        ///  Buy
        /// </summary>
        public const char Buy = 'B';

        /// <summary>
        ///  Sell
        /// </summary>
        public const char Sell = 'S';

        /// <summary>
        ///  Buy Aon
        /// </summary>
        public const char Buy = 'X';

        /// <summary>
        ///  Sell Aon
        /// </summary>
        public const char Sell = 'Y';

        /// <summary>
        ///  Buy Implied
        /// </summary>
        public const char Buy = 'M';

        /// <summary>
        ///  Sell Implied
        /// </summary>
        public const char Sell = 'N';

        /// <summary>
        ///  Length of Market Side in bytes
        /// </summary>
        public const int Length = 1;
    }
}
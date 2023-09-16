using System.Runtime.CompilerServices;;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Auction Type
    /// </summary>

    public struct AuctionType
    {
        /// <summary>
        ///  Opening
        /// </summary>
        public const char Opening = 'O';

        /// <summary>
        ///  Reopening
        /// </summary>
        public const char Reopening = 'R';

        /// <summary>
        ///  Order Exposure
        /// </summary>
        public const char Exposure = 'I';

        /// <summary>
        ///  Length of Auction Type in bytes
        /// </summary>
        public const int Length = 1;
    }
}
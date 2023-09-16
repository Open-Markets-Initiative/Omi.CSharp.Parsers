using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Entry Type Statistics: Zeroed Character Enum
    /// </summary>

    public struct MdEntryTypeStatistics
    {
        /// <summary>
        ///  Open Price
        /// </summary>
        public const char OpenPrice = '4';

        /// <summary>
        ///  High Trade
        /// </summary>
        public const char HighTrade = '7';

        /// <summary>
        ///  Low Trade
        /// </summary>
        public const char LowTrade = '8';

        /// <summary>
        ///  Trading Session Volume Weighted Average Price
        /// </summary>
        public const char Vwap = '9';

        /// <summary>
        ///  Highest Bid
        /// </summary>
        public const char HighestBid = 'N';

        /// <summary>
        ///  Lowest Offer
        /// </summary>
        public const char LowestOffer = 'O';

        /// <summary>
        ///  Fix Tag for Md Entry Type Statistics
        /// </summary>
        public const ushort FixTag = 269;

        /// <summary>
        ///  Length of Md Entry Type Statistics in bytes
        /// </summary>
        public const int Length = 1;
    }
}
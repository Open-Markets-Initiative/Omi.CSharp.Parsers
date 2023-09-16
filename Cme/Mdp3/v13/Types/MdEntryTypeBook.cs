using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Entry Type Book: Zeroed Character Enum
    /// </summary>

    public struct MdEntryTypeBook
    {
        /// <summary>
        ///  Bid
        /// </summary>
        public const char Bid = '0';

        /// <summary>
        ///  Offer
        /// </summary>
        public const char Offer = '1';

        /// <summary>
        ///  Implied Bid
        /// </summary>
        public const char ImpliedBid = 'E';

        /// <summary>
        ///  Implied Offer
        /// </summary>
        public const char ImpliedOffer = 'F';

        /// <summary>
        ///  Book Reset
        /// </summary>
        public const char BookReset = 'J';

        /// <summary>
        ///  Market Best Offer
        /// </summary>
        public const char MarketBestOffer = 'w';

        /// <summary>
        ///  Market Best Bid
        /// </summary>
        public const char MarketBestBid = 'x';

        /// <summary>
        ///  Fix Tag for Md Entry Type Book
        /// </summary>
        public const ushort FixTag = 269;

        /// <summary>
        ///  Length of Md Entry Type Book in bytes
        /// </summary>
        public const int Length = 1;
    }
}
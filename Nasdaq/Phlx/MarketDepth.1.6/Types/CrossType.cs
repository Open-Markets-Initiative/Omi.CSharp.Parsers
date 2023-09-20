using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Cross Type
    /// </summary>

    public struct CrossType
    {
        /// <summary>
        ///  Opening Reopening Auction
        /// </summary>
        public const char OpeningReopening = 'O';

        /// <summary>
        ///  Length of Cross Type in bytes
        /// </summary>
        public const int Length = 1;
    }
}
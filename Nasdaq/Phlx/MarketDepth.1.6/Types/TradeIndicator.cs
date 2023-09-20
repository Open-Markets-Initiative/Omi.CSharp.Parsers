using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Trade Indicator
    /// </summary>

    public struct TradeIndicator
    {
        /// <summary>
        ///  Non Displayable Simple Order Cross
        /// </summary>
        public const char NonDisplayable = 'O';

        /// <summary>
        ///  Complex Order Cross
        /// </summary>
        public const char Complex = 'C';

        /// <summary>
        ///  Pixl Auction Cross
        /// </summary>
        public const char Pixl = 'P';

        /// <summary>
        ///  Length of Trade Indicator in bytes
        /// </summary>
        public const int Length = 1;
    }
}
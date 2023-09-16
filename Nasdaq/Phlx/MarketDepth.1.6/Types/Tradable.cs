using System.Runtime.CompilerServices;;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Tradable
    /// </summary>

    public struct Tradable
    {
        /// <summary>
        ///  Option Is Tradable
        /// </summary>
        public const char Tradable = 'Y';

        /// <summary>
        ///  Option Is Not Tradable
        /// </summary>
        public const char NotTradable = 'N';

        /// <summary>
        ///  Length of Tradable in bytes
        /// </summary>
        public const int Length = 1;
    }
}
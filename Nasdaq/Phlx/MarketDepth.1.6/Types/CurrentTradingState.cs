using System.Runtime.CompilerServices;;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Current Trading State
    /// </summary>

    public struct CurrentTradingState
    {
        /// <summary>
        ///  Halt In Effect
        /// </summary>
        public const char Halt = 'H';

        /// <summary>
        ///  Trading On Phlx®
        /// </summary>
        public const char Trading = 'T';

        /// <summary>
        ///  Buy Side Trading Suspended Exhausted Ie Buy Orders Are Not Executable And Buy Side Book Is Non Firm
        /// </summary>
        public const char BuySideTradingSuspendedOrExhausted = 'B';

        /// <summary>
        ///  Sell Side Trading Suspended Exhausted Ie Sell Orders Are Not Executable And Sell Side Book Is Non Firm
        /// </summary>
        public const char SellSideTradingSuspendedOrExhausted = 'S';

        /// <summary>
        ///  Length of Current Trading State in bytes
        /// </summary>
        public const int Length = 1;
    }
}
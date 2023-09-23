using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Event Code: Zeroed Character Enum
    /// </summary>

    public struct EventCode
    {
        /// <summary>
        ///  Normal Trade
        /// </summary>
        public const char NormalTrade = '0';

        /// <summary>
        ///  Cancelled Trade
        /// </summary>
        public const char CancelledTrade = '1';

        /// <summary>
        ///  Adjusted Trade
        /// </summary>
        public const char AdjustedTrade = '2';

        /// <summary>
        ///  Length of Event Code in bytes
        /// </summary>
        public const int Length = 1;
    }
}
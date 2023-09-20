using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Md Entry Type Indices: Zeroed Character Enum
    /// </summary>

    public struct MdEntryTypeIndices
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
        ///  Trade
        /// </summary>
        public const char Trade = '2';

        /// <summary>
        ///  Index Value
        /// </summary>
        public const char IndexValue = '3';

        /// <summary>
        ///  Opening Value
        /// </summary>
        public const char OpeningValue = '4';

        /// <summary>
        ///  Closing Price
        /// </summary>
        public const char ClosingPrice = '5';

        /// <summary>
        ///  Settlement Price
        /// </summary>
        public const char SettlementPrice = '6';

        /// <summary>
        ///  Session High Price
        /// </summary>
        public const char SessionHighPrice = '7';

        /// <summary>
        ///  Session Low Price
        /// </summary>
        public const char SessionLowPrice = '8';

        /// <summary>
        ///  Trade Volume
        /// </summary>
        public const char TradeVolume = 'e';

        /// <summary>
        ///  Fix Tag for Md Entry Type Indices
        /// </summary>
        public const ushort FixTag = 269;

        /// <summary>
        ///  Length of Md Entry Type Indices in bytes
        /// </summary>
        public const int Length = 1;
    }
}
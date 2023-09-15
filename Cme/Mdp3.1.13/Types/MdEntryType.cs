namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Md Entry Type : Zeroed Character Enum
    /// </summary>

    public struct MdEntryType
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
        ///  Open Price
        /// </summary>
        public const char OpenPrice = '4';

        /// <summary>
        ///  Settlement Price
        /// </summary>
        public const char SettlementPrice = '6';

        /// <summary>
        ///  Trading Session High Price
        /// </summary>
        public const char TradingSessionHighPrice = '7';

        /// <summary>
        ///  Trading Session Low Price
        /// </summary>
        public const char TradingSessionLowPrice = '8';

        /// <summary>
        ///  Trading Session Volume Weighted Average Price
        /// </summary>
        public const char Vwap = '9';

        /// <summary>
        ///  Cleared Volume
        /// </summary>
        public const char ClearedVolume = 'B';

        /// <summary>
        ///  Open Interest
        /// </summary>
        public const char OpenInterest = 'C';

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
        ///  Session High Bid
        /// </summary>
        public const char SessionHighBid = 'N';

        /// <summary>
        ///  Session Low Offer
        /// </summary>
        public const char SessionLowOffer = 'O';

        /// <summary>
        ///  Fixing Price
        /// </summary>
        public const char FixingPrice = 'W';

        /// <summary>
        ///  Electronic Volume
        /// </summary>
        public const char ElectronicVolume = 'e';

        /// <summary>
        ///  Threshold Limits and Price Band Variation
        /// </summary>
        public const char ThresholdLimitsandPriceBandVariation = 'g';

        /// <summary>
        ///  Market Best Offer
        /// </summary>
        public const char MarketBestOffer = 'w';

        /// <summary>
        ///  Market Best Bid
        /// </summary>
        public const char MarketBestBid = 'x';

        /// <summary>
        ///  Fix Tag for Md Entry Type
        /// </summary>
        public const ushort FixTag = 269;

        /// <summary>
        ///  Length of Md Entry Type  in bytes
        /// </summary>
        public const int Length = 1;
    }
}
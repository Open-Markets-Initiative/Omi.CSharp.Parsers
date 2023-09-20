namespace Eurex.Eobi
{
    /// <summary>
    ///  Security Trading Event
    /// </summary>
    public enum SecurityTradingEvent : byte
    {
        /// <summary>
        ///  Price volatility, auction is extended
        /// </summary>
        PriceVolatilityAuctionIsExtended = 10,

        /// <summary>
        ///  Price volatility, auction is extended again
        /// </summary>
        PriceVolatilityAuctionIsExtendedAgain = 11,

        /// <summary>
        ///  
        /// </summary>
        SecurityTradingEventMaximumValue = 11,

        /// <summary>
        ///  
        /// </summary>
        SecurityTradingEventMinimumValue = 10,

    }
}
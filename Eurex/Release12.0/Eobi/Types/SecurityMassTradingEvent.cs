namespace Eurex.Eobi
{
    /// <summary>
    ///  Security Mass Trading Event
    /// </summary>
    public enum SecurityMassTradingEvent : byte
    {
        /// <summary>
        ///  Price volatility, auction is extended
        /// </summary>
        PriceVolatilityAuctionIsExtended = 10;

        /// <summary>
        ///  Price volatility, auction is extended again
        /// </summary>
        PriceVolatilityAuctionIsExtendedAgain = 11;

        /// <summary>
        ///  
        /// </summary>
        SecurityMassTradingEventMaximumValue = 11;

        /// <summary>
        ///  
        /// </summary>
        SecurityMassTradingEventMinimumValue = 10;

    }
}
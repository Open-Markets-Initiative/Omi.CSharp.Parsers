namespace Eurex.Eobi
{
    /// <summary>
    ///  Potential Security Trading Event:
    /// </summary>
    public enum PotentialSecurityTradingEvent : byte
    {
        /// <summary>
        ///  None
        /// </summary>
        None = 0;

        /// <summary>
        ///  Price volatility, auction is extended
        /// </summary>
        PriceVolatilityAuctionIsExtended = 10;

        /// <summary>
        ///  
        /// </summary>
        PotentialSecurityTradingEventMaximumValue = 10;

        /// <summary>
        ///  
        /// </summary>
        PotentialSecurityTradingEventMinimumValue = 0;

    }
}
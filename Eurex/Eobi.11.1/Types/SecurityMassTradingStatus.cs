namespace Eurex.T7
{
    /// <summary>
    ///  Security Mass Trading Status:
    /// </summary>
    public enum SecurityMassTradingStatus : byte
    {
        /// <summary>
        ///  
        /// </summary>
        TradingHalt = 2;

        /// <summary>
        ///  
        /// </summary>
        MarketImbalanceBuy = 7;

        /// <summary>
        ///  
        /// </summary>
        MarketImbalanceSell = 8;

        /// <summary>
        ///  
        /// </summary>
        Closed = 200;

        /// <summary>
        ///  
        /// </summary>
        Restricted = 201;

        /// <summary>
        ///  
        /// </summary>
        Book = 202;

        /// <summary>
        ///  
        /// </summary>
        Continuous = 203;

        /// <summary>
        ///  
        /// </summary>
        OpeningAuction = 204;

        /// <summary>
        ///  
        /// </summary>
        OpeningAuctionFreeze = 205;

        /// <summary>
        ///  
        /// </summary>
        IntradayAuction = 206;

        /// <summary>
        ///  
        /// </summary>
        IntradayAuctionFreeze = 207;

        /// <summary>
        ///  
        /// </summary>
        CircuitBreakerAuction = 208;

        /// <summary>
        ///  
        /// </summary>
        CircuitBreakerAuctionFreeze = 209;

        /// <summary>
        ///  
        /// </summary>
        ClosingAuction = 210;

        /// <summary>
        ///  
        /// </summary>
        ClosingAuctionFreeze = 211;

        /// <summary>
        ///  
        /// </summary>
        IpoAuction = 212;

        /// <summary>
        ///  
        /// </summary>
        IpoAuctionFreeze = 213;

        /// <summary>
        ///  
        /// </summary>
        PreCall = 214;

        /// <summary>
        ///  
        /// </summary>
        Call = 215;

        /// <summary>
        ///  
        /// </summary>
        Freeze = 216;

        /// <summary>
        ///  
        /// </summary>
        TradeAtClose = 217;

        /// <summary>
        ///  
        /// </summary>
        SecurityMassTradingStatusMaximumValue = 217;

        /// <summary>
        ///  
        /// </summary>
        SecurityMassTradingStatusMinimumValue = 2;

    }
}
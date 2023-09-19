namespace Eurex.Eobi
{
    /// <summary>
    ///  Match Type
    /// </summary>
    public enum MatchType : byte
    {
        /// <summary>
        ///  Manual Trade Entry
        /// </summary>
        ConfirmedTradeReport = 3;

        /// <summary>
        ///  Trade from Uncrossing
        /// </summary>
        CrossAuction = 5;

        /// <summary>
        ///  Trade from Auction
        /// </summary>
        CallAuction = 7;

        /// <summary>
        ///  Trade from Liquidity Improvement Cross
        /// </summary>
        LiquidityImprovementCross = 13;

        /// <summary>
        ///  Price Without Turnover in Continuous Auction
        /// </summary>
        ContinuousAuction = 14;

        /// <summary>
        ///  
        /// </summary>
        MatchTypeMaximumValue = 14;

        /// <summary>
        ///  
        /// </summary>
        MatchTypeMinimumValue = 3;

    }
}
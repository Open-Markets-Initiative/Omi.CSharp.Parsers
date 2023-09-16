namespace Eurex.Eobi
{
    /// <summary>
    ///  Trade Condition:
    /// </summary>
    public enum TradeCondition : ushort
    {
        /// <summary>
        ///  
        /// </summary>
        ImpliedTrade = 1;

        /// <summary>
        ///  Out of sequence (k)
        /// </summary>
        OutOfSequence = 107;

        /// <summary>
        ///  Midpoint price (BB)
        /// </summary>
        MidpointPrice = 155;

        /// <summary>
        ///  Trading On Terms Of Issue (BC)
        /// </summary>
        TradingOnTermsOfIssue = 156;

        /// <summary>
        ///  Special Auction (SA)
        /// </summary>
        SpecialAuction = 596;

        /// <summary>
        ///  Trade At Close (TC)
        /// </summary>
        TradeAtClose = 624;

        /// <summary>
        ///  
        /// </summary>
        TradeConditionMaximumValue = 624;

        /// <summary>
        ///  
        /// </summary>
        TradeConditionMinimumValue = 1;

    }
}
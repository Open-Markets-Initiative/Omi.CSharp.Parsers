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
        ///  Retail (XR)
        /// </summary>
        Retail = 743;

        /// <summary>
        ///  
        /// </summary>
        TradeConditionMaximumValue = 743;

        /// <summary>
        ///  
        /// </summary>
        TradeConditionMinimumValue = 1;

    }
}
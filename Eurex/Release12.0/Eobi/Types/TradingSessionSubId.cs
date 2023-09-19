namespace Eurex.Eobi
{
    /// <summary>
    ///  Trading Session Sub Id
    /// </summary>
    public enum TradingSessionSubId : byte
    {
        /// <summary>
        ///  
        /// </summary>
        PreTrading = 1;

        /// <summary>
        ///  
        /// </summary>
        Continuous = 3;

        /// <summary>
        ///  
        /// </summary>
        Closing = 4;

        /// <summary>
        ///  
        /// </summary>
        PostTrading = 5;

        /// <summary>
        ///  
        /// </summary>
        Quiescent = 7;

        /// <summary>
        ///  
        /// </summary>
        TradingSessionSubIDMaximumValue = 7;

        /// <summary>
        ///  
        /// </summary>
        TradingSessionSubIDMinimumValue = 1;

    }
}
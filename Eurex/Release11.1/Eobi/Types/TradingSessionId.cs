namespace Eurex.Eobi
{
    /// <summary>
    ///  Trading Session Id
    /// </summary>
    public enum TradingSessionId : byte
    {
        /// <summary>
        ///  
        /// </summary>
        Day = 1;

        /// <summary>
        ///  
        /// </summary>
        Morning = 3;

        /// <summary>
        ///  
        /// </summary>
        Evening = 5;

        /// <summary>
        ///  
        /// </summary>
        AfterHours = 6;

        /// <summary>
        ///  
        /// </summary>
        Holiday = 7;

        /// <summary>
        ///  
        /// </summary>
        TradingSessionIDMaximumValue = 7;

        /// <summary>
        ///  
        /// </summary>
        TradingSessionIDMinimumValue = 1;

    }
}
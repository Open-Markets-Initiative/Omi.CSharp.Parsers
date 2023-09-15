namespace Eurex.T7
{
    /// <summary>
    ///  Match Sub Type:
    /// </summary>
    public enum MatchSubType : byte
    {
        /// <summary>
        ///  
        /// </summary>
        OpeningAuction = 1;

        /// <summary>
        ///  
        /// </summary>
        ClosingAuction = 2;

        /// <summary>
        ///  
        /// </summary>
        IntradayAuction = 3;

        /// <summary>
        ///  
        /// </summary>
        CircuitBreakerAuction = 4;

        /// <summary>
        ///  
        /// </summary>
        IpoAuction = 5;

        /// <summary>
        ///  
        /// </summary>
        MatchSubTypeMaximumValue = 5;

        /// <summary>
        ///  
        /// </summary>
        MatchSubTypeMinimumValue = 1;

    }
}
namespace Eurex.T7
{
    /// <summary>
    ///  Md Entry Type:
    /// </summary>
    public enum MdEntryType : byte
    {
        /// <summary>
        ///  
        /// </summary>
        Trade = 2;

        /// <summary>
        ///  
        /// </summary>
        OpeningPrice = 4;

        /// <summary>
        ///  
        /// </summary>
        ClosingPrice = 5;

        /// <summary>
        ///  
        /// </summary>
        HighPrice = 7;

        /// <summary>
        ///  
        /// </summary>
        LowPrice = 8;

        /// <summary>
        ///  
        /// </summary>
        TradeVolume = 66;

        /// <summary>
        ///  
        /// </summary>
        PreviousClosingPrice = 101;

        /// <summary>
        ///  
        /// </summary>
        OpeningAuction = 200;

        /// <summary>
        ///  
        /// </summary>
        IntradayAuction = 201;

        /// <summary>
        ///  
        /// </summary>
        CircuitBreakerAuction = 202;

        /// <summary>
        ///  
        /// </summary>
        ClosingAuction = 203;

        /// <summary>
        ///  
        /// </summary>
        IpoAuction = 204;

        /// <summary>
        ///  
        /// </summary>
        MdEntryTypeMaximumValue = 204;

        /// <summary>
        ///  
        /// </summary>
        MdEntryTypeMinimumValue = 2;

    }
}
namespace Eurex.T7
{
    /// <summary>
    ///  Cross Request Type:
    /// </summary>
    public enum CrossRequestType : byte
    {
        /// <summary>
        ///  
        /// </summary>
        CrossAnnouncement = 1;

        /// <summary>
        ///  
        /// </summary>
        LiquidityImprovementCross = 2;

        /// <summary>
        ///  
        /// </summary>
        CrossRequestTypeMaximumValue = 2;

        /// <summary>
        ///  
        /// </summary>
        CrossRequestTypeMinimumValue = 1;

    }
}
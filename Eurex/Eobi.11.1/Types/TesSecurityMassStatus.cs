namespace Eurex.T7
{
    /// <summary>
    ///  Tes Security Mass Status:
    /// </summary>
    public enum TesSecurityMassStatus : byte
    {
        /// <summary>
        ///  
        /// </summary>
        Active = 1;

        /// <summary>
        ///  
        /// </summary>
        Inactive = 2;

        /// <summary>
        ///  
        /// </summary>
        Expired = 4;

        /// <summary>
        ///  
        /// </summary>
        Suspended = 9;

        /// <summary>
        ///  
        /// </summary>
        TesSecurityMassStatusMaximumValue = 9;

        /// <summary>
        ///  
        /// </summary>
        TesSecurityMassStatusMinimumValue = 1;

    }
}
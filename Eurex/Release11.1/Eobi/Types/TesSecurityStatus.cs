namespace Eurex.Eobi
{
    /// <summary>
    ///  Tes Security Status:
    /// </summary>
    public enum TesSecurityStatus : byte
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
        TesSecurityStatusMaximumValue = 9;

        /// <summary>
        ///  
        /// </summary>
        TesSecurityStatusMinimumValue = 1;

    }
}
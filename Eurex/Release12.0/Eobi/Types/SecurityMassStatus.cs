namespace Eurex.Eobi
{
    /// <summary>
    ///  Security Mass Status
    /// </summary>
    public enum SecurityMassStatus : byte
    {
        /// <summary>
        ///  
        /// </summary>
        Active = 1,

        /// <summary>
        ///  
        /// </summary>
        Inactive = 2,

        /// <summary>
        ///  
        /// </summary>
        Expired = 4,

        /// <summary>
        ///  
        /// </summary>
        KnockedOut = 6,

        /// <summary>
        ///  
        /// </summary>
        KnockOutRevoked = 7,

        /// <summary>
        ///  
        /// </summary>
        Suspended = 9,

        /// <summary>
        ///  
        /// </summary>
        PendingDeletion = 11,

        /// <summary>
        ///  
        /// </summary>
        KnockedOutAndSuspended = 12,

        /// <summary>
        ///  
        /// </summary>
        SecurityMassStatusMaximumValue = 12,

        /// <summary>
        ///  
        /// </summary>
        SecurityMassStatusMinimumValue = 1,

    }
}
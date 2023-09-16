namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  User Session Status: Indicates the status of the gateway session.
    /// </summary>
    public enum UserSessionStatus : byte
    {
        /// <summary>
        ///  Active
        /// </summary>
        Active = 1;

        /// <summary>
        ///  Inactive
        /// </summary>
        Inactive = 2;

        /// <summary>
        ///  Prospect
        /// </summary>
        Prospect = 3;

    }
}
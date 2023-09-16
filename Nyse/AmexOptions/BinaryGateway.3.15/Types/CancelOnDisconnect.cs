namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Cancel On Disconnect: Note: the firm may only “upgrade” the Cancel on Disconnect subscription setting through the gateway Session Configuration Request. That is, if
    /// </summary>
    public enum CancelOnDisconnect : byte
    {
        /// <summary>
        ///  Enable Cancel On Disconnect Day
        /// </summary>
        EnableCancelOnDisconnectDay = 1;

        /// <summary>
        ///  Enable Cancel On Disconnect All
        /// </summary>
        EnableCancelOnDisconnectAll = 2;

    }
}
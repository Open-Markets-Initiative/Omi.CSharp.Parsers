namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Status: Pillar Status Code
    /// </summary>
    public enum Status : byte
    {
        /// <summary>
        ///  Request processed successfully
        /// </summary>
        RequestProcessedSuccessfully = 0;

        /// <summary>
        ///  Not logged in
        /// </summary>
        NotLoggedIn = 18;

    }
}
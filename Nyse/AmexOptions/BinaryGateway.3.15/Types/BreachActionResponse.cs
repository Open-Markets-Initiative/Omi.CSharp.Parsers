namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Breach Action Response: BreachActionResponse
    /// </summary>
    public enum BreachActionResponse : byte
    {
        /// <summary>
        ///  Not Applicable
        /// </summary>
        NotApplicable = 0;

        /// <summary>
        ///  Notification
        /// </summary>
        Notification = 1;

        /// <summary>
        ///  Cancel Non Auction Orders
        /// </summary>
        CancelNonAuctionOrders = 2;

        /// <summary>
        ///  Block
        /// </summary>
        Block = 3;

    }
}
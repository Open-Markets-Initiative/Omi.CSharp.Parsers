namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Breach Action Request: BreachActionRequest
    /// </summary>
    public enum BreachActionRequest : byte
    {
        /// <summary>
        ///  Not Applicable
        /// </summary>
        NotApplicable = 0,

        /// <summary>
        ///  Notifications Only
        /// </summary>
        NotificationsOnly = 1,

        /// <summary>
        ///  Cancel Non Auction Orders And Block
        /// </summary>
        CancelNonAuctionOrdersAndBlock = 2,

        /// <summary>
        ///  Block Only
        /// </summary>
        BlockOnly = 3,

    }
}
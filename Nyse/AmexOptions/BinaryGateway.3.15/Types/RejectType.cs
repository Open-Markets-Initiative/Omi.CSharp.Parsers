namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Reject Type: RejectType
    /// </summary>
    public enum RejectType : byte
    {
        /// <summary>
        ///  Order Cancel Replace Reject
        /// </summary>
        OrderCancelReplaceReject = 1,

        /// <summary>
        ///  Modify Request Reject
        /// </summary>
        ModifyRequestReject = 2,

        /// <summary>
        ///  Cancel Request Reject
        /// </summary>
        CancelRequestReject = 3,

        /// <summary>
        ///  Bulk Cancel Request Reject
        /// </summary>
        BulkCancelRequestReject = 4,

        /// <summary>
        ///  New Bulk Quote Reject
        /// </summary>
        NewBulkQuoteReject = 5,

        /// <summary>
        ///  Manual Action Response Reject
        /// </summary>
        ManualActionResponseReject = 6,

        /// <summary>
        ///  Risk Limit Update Request Reject
        /// </summary>
        RiskLimitUpdateRequestReject = 7,

        /// <summary>
        ///  Bulk Cancel Request Reject Options
        /// </summary>
        BulkCancelRequestRejectOptions = 8,

        /// <summary>
        ///  Cross Order Reject
        /// </summary>
        CrossOrderReject = 9,

        /// <summary>
        ///  New Complex Series Request Reject
        /// </summary>
        NewComplexSeriesRequestReject = 10,

        /// <summary>
        ///  Risk Action Request Reject
        /// </summary>
        RiskActionRequestReject = 11,

    }
}
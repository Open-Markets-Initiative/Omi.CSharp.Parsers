namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Ack Type: AckType
    /// </summary>
    public enum AckType : byte
    {
        /// <summary>
        ///  None
        /// </summary>
        None = 0;

        /// <summary>
        ///  New Interest
        /// </summary>
        NewInterest = 1;

        /// <summary>
        ///  Order Priority Update New Order Id
        /// </summary>
        OrderPriorityUpdateNewOrderId = 2;

        /// <summary>
        ///  Order Priority Update Same Order Id
        /// </summary>
        OrderPriorityUpdateSameOrderId = 3;

        /// <summary>
        ///  Bulk Cancel Ack
        /// </summary>
        BulkCancelAck = 4;

        /// <summary>
        ///  Pending Cancel
        /// </summary>
        PendingCancel = 5;

        /// <summary>
        ///  Pending Replace
        /// </summary>
        PendingReplace = 6;

        /// <summary>
        ///  Pending Modify
        /// </summary>
        PendingModify = 7;

        /// <summary>
        ///  Replaced
        /// </summary>
        Replaced = 8;

        /// <summary>
        ///  Modified
        /// </summary>
        Modified = 9;

        /// <summary>
        ///  Eligible For Cross
        /// </summary>
        EligibleForCross = 10;

        /// <summary>
        ///  Canceled
        /// </summary>
        Canceled = 11;

        /// <summary>
        ///  Done For Day
        /// </summary>
        DoneForDay = 12;

        /// <summary>
        ///  Billable Cancel Adding Liquidity
        /// </summary>
        BillableCancelAddingLiquidity = 13;

        /// <summary>
        ///  Billable Cancel Removing Liquidity
        /// </summary>
        BillableCancelRemovingLiquidity = 14;

        /// <summary>
        ///  Billable Cancel Subdollar Adding Liquidity
        /// </summary>
        BillableCancelSubdollarAddingLiquidity = 15;

        /// <summary>
        ///  Billable Cancel Subdollar Removing Liquidity
        /// </summary>
        BillableCancelSubdollarRemovingLiquidity = 16;

        /// <summary>
        ///  Gtc Renewal Restatement
        /// </summary>
        GtcRenewalRestatement = 17;

    }
}
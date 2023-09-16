namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Risk Action Type: 0 = Not Applicable
    /// </summary>
    public enum RiskActionType : byte
    {
        /// <summary>
        ///  Not Applicable
        /// </summary>
        NotApplicable = 0;

        /// <summary>
        ///  Query Risk Entity For Current Risk Control Configscalculationsstatus
        /// </summary>
        QueryRiskEntityForCurrentRiskControlConfigscalculationsstatus = 1;

        /// <summary>
        ///  Kill Switch Block
        /// </summary>
        KillSwitchBlock = 2;

        /// <summary>
        ///  Kill Switch Un Block
        /// </summary>
        KillSwitchUnBlock = 3;

        /// <summary>
        ///  Kill Switch Cancel Auction Orders
        /// </summary>
        KillSwitchCancelAuctionOrders = 4;

        /// <summary>
        ///  Kill Switch Cancel Non Auction Orders
        /// </summary>
        KillSwitchCancelNonAuctionOrders = 5;

        /// <summary>
        ///  Kill Switch Cancel Gtc Orders
        /// </summary>
        KillSwitchCancelGtcOrders = 6;

        /// <summary>
        ///  Approve Reinstatement
        /// </summary>
        ApproveReinstatement = 7;

        /// <summary>
        ///  Risk Entity Reinstated All Necessary Reinstatement Approvals Received Reinstatement Processed
        /// </summary>
        RiskEntityReinstatedAllNecessaryReinstatementApprovalsReceivedReinstatementProcessed = 8;

    }
}
namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Risk Control Type: RiskControlType
    /// </summary>
    public enum RiskControlType : byte
    {
        /// <summary>
        ///  Not Applicable
        /// </summary>
        NotApplicable = 0;

        /// <summary>
        ///  Single Order Max Qty
        /// </summary>
        SingleOrderMaxQty = 1;

        /// <summary>
        ///  Single Order Max Notional Value
        /// </summary>
        SingleOrderMaxNotionalValue = 2;

        /// <summary>
        ///  Gross Credit
        /// </summary>
        GrossCredit = 3;

        /// <summary>
        ///  Activitybased Rolling Transaction
        /// </summary>
        ActivitybasedRollingTransaction = 8;

        /// <summary>
        ///  Activitybased Rolling Volume
        /// </summary>
        ActivitybasedRollingVolume = 9;

        /// <summary>
        ///  Activitybased Rolling Percentage
        /// </summary>
        ActivitybasedRollingPercentage = 10;

        /// <summary>
        ///  Activitybased Global Risk Mitigation Protection For Transaction Volume Percentage
        /// </summary>
        ActivitybasedGlobalRiskMitigationProtectionForTransactionVolumePercentage = 11;

    }
}
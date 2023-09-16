namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Blocked By Breach Indicator: BlockedByBreachIndicator
    /// </summary>
    public enum BlockedByBreachIndicator : byte
    {
        /// <summary>
        ///  Not Blocked By Breach
        /// </summary>
        NotBlockedByBreach = 0;

        /// <summary>
        ///  Blocked By Breach
        /// </summary>
        BlockedByBreach = 1;

        /// <summary>
        ///  Blocked By Arbitrage Check
        /// </summary>
        BlockedByArbitrageCheck = 2;

        /// <summary>
        ///  Blocked By Intrinsic Value Check
        /// </summary>
        BlockedByIntrinsicValueCheck = 3;

    }
}
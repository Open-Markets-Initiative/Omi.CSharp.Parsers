namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Blocked By Kill Switch Indicator: BlockedByKillSwitchIndicator
    /// </summary>
    public enum BlockedByKillSwitchIndicator : byte
    {
        /// <summary>
        ///  Not Blocked By Kill Switch
        /// </summary>
        NotBlockedByKillSwitch = 0,

        /// <summary>
        ///  Blocked By Kill Switch
        /// </summary>
        BlockedByKillSwitch = 1,

    }
}
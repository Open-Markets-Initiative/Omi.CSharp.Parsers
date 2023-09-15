namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Self Trade Type: Applies to all Quote messages in repeating group.
    /// </summary>
    public enum SelfTradeType : byte
    {
        /// <summary>
        ///  Use Current Session Configuration Stp Setting For The Username
        /// </summary>
        UseCurrentSessionConfigurationStpSettingForTheUsername = 0;

        /// <summary>
        ///  No Self Trade Prevention
        /// </summary>
        NoSelfTradePrevention = 1;

        /// <summary>
        ///  Cancel Newest
        /// </summary>
        CancelNewest = 2;

        /// <summary>
        ///  Cancel Oldest
        /// </summary>
        CancelOldest = 3;

        /// <summary>
        ///  Cancel Both
        /// </summary>
        CancelBoth = 4;

        /// <summary>
        ///  Cancel Decrement
        /// </summary>
        CancelDecrement = 5;

    }
}
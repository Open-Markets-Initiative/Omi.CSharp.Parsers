namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Leg Open Close: Indicates sender’s position of each leg of a Complex order.
    /// </summary>
    public enum LegOpenClose : ulong
    {
        /// <summary>
        ///  Open
        /// </summary>
        Open = 0;

        /// <summary>
        ///  Close
        /// </summary>
        Close = 1;

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
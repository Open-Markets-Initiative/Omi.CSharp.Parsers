namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Self Trade Prevention: Session level default for the STP value on all Order and Cancel/Replace requests entered on the session.
    /// </summary>
    public enum SelfTradePrevention : byte
    {
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
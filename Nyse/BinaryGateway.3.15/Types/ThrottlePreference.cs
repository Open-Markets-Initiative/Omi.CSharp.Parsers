namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Throttle Preference: ThrottlePreference
    /// </summary>
    public enum ThrottlePreference : byte
    {
        /// <summary>
        ///  Queue Orders When Throttled
        /// </summary>
        QueueOrdersWhenThrottled = 0;

        /// <summary>
        ///  Reject Orders When Throttled
        /// </summary>
        RejectOrdersWhenThrottled = 1;

    }
}
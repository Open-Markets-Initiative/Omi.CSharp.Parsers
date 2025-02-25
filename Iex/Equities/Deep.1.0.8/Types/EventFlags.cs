namespace Iex.Deep
{
    /// <summary>
    ///  Event Flags: Identifies event processing by the System
    /// </summary>
    public enum EventFlags : byte
    {
        /// <summary>
        ///  Order Book Is Processing An Event
        /// </summary>
        OrderBookIsProcessingAnEvent = 0,

        /// <summary>
        ///  Event Processing Complete
        /// </summary>
        EventProcessingComplete = 1,

    }
}
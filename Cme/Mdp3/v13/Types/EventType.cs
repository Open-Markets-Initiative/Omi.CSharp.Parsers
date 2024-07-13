namespace Cme.Mdp3
{
    /// <summary>
    ///  Event Type: Code to represent the type of event
    /// </summary>
    public enum EventType : byte
    {
        /// <summary>
        ///  EventType Fix Tag
        /// </summary>
        Fix = 865,

        /// <summary>
        ///  Activation
        /// </summary>
        Activation = 5,

        /// <summary>
        ///  Last Eligible Trade Date
        /// </summary>
        LastEligibleTradeDate = 7,

    }
}
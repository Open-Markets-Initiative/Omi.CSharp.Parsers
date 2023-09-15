namespace Cme.Sbe
{
    /// <summary>
    ///  Event Type: Code to represent the type of event
    /// </summary>
    public enum EventType : byte
    {
        /// <summary>
        ///  Activation
        /// </summary>
        Activation = 5;

        /// <summary>
        ///  Last Eligible Trade Date
        /// </summary>
        LastEligibleTradeDate = 7;

    }
}
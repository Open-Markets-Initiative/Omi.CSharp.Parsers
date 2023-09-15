namespace Cme.Sbe
{
    /// <summary>
    ///  Halt Reason: Identifies the reason for the status change
    /// </summary>
    public enum HaltReason : byte
    {
        /// <summary>
        ///  Group Schedule
        /// </summary>
        GroupSchedule = 0;

        /// <summary>
        ///  Surveillance Intervention
        /// </summary>
        SurveillanceIntervention = 1;

        /// <summary>
        ///  Market Event
        /// </summary>
        MarketEvent = 2;

        /// <summary>
        ///  Instrument Activation
        /// </summary>
        InstrumentActivation = 3;

        /// <summary>
        ///  Instrument Expiration
        /// </summary>
        InstrumentExpiration = 4;

        /// <summary>
        ///  Unknown
        /// </summary>
        Unknown = 5;

        /// <summary>
        ///  Recovery In Process
        /// </summary>
        RecoveryInProcess = 6;

        /// <summary>
        ///  Trade Date Roll
        /// </summary>
        TradeDateRoll = 7;

    }
}
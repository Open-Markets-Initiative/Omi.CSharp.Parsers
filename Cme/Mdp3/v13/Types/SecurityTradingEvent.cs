namespace Cme.Mdp3;

/// <summary>
///  Security Trading Event: Identifies an additional event or a rule related to the status
/// </summary>

public enum SecurityTradingEvent : byte
{
    /// <summary>
    ///  SecurityTradingEvent Fix Tag
    /// </summary>
    Fix = 1174,

    /// <summary>
    ///  No Event
    /// </summary>
    NoEvent = 0,

    /// <summary>
    ///  No Cancel
    /// </summary>
    NoCancel = 1,

    /// <summary>
    ///  Reset Statistics
    /// </summary>
    ResetStatistics = 4,

    /// <summary>
    ///  Implied Matching ON
    /// </summary>
    ImpliedMatchingOn = 5,

    /// <summary>
    ///  Implied Matching OFF
    /// </summary>
    ImpliedMatchingOff = 6,

    /// <summary>
    ///  End Of Workup
    /// </summary>
    EndOfWorkup = 7,

}

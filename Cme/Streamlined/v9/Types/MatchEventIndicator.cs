namespace Cme.Streamlined;

using System.Runtime.CompilerServices;

/// <summary>
///  Match Event Indicator: Bitfield
/// </summary>

public sealed class MatchEventIndicator
{
    /// <summary>
    ///  End Of Event
    /// </summary>
    public const byte EndOfEvent = 1 << 0;

    /// <summary>
    ///  Reserved
    /// </summary>
    public const byte Reserved = 1 << 1;

    /// <summary>
    ///  Recovery Msg
    /// </summary>
    public const byte RecoveryMsg = 1 << 2;

    /// <summary>
    ///  Last Implied Msg
    /// </summary>
    public const byte LastImpliedMsg = 1 << 3;

    /// <summary>
    ///  Last Stats Msg
    /// </summary>
    public const byte LastStatsMsg = 1 << 4;

    /// <summary>
    ///  Last Quote Msg
    /// </summary>
    public const byte LastQuoteMsg = 1 << 5;

    /// <summary>
    ///  Last Volume Msg
    /// </summary>
    public const byte LastVolumeMsg = 1 << 6;

    /// <summary>
    ///  Last Trade Msg
    /// </summary>
    public const byte LastTradeMsg = 1 << 7;

    /// <summary>
    ///  Length of Match Event Indicator in bytes
    /// </summary>
    public const int Length = 1;
}

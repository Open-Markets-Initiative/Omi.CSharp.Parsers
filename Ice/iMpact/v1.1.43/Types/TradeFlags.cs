namespace Ice.iMpact;

using System.Runtime.CompilerServices;

/// <summary>
///  Trade Flags: Bitfield
/// </summary>

public sealed class TradeFlags
{
    /// <summary>
    ///  Is Rfc Crossing
    /// </summary>
    public const byte IsRfcCrossing = 1 << 0;

    /// <summary>
    ///  Is Leg Deal Outside Ipl
    /// </summary>
    public const byte IsLegDealOutsideIpl = 1 << 1;

    /// <summary>
    ///  Is Implied Order
    /// </summary>
    public const byte IsImpliedOrder = 1 << 2;

    /// <summary>
    ///  Is Vertical Split
    /// </summary>
    public const byte IsVerticalSplit = 1 << 3;

    /// <summary>
    ///  Future Trade Flags
    /// </summary>
    public const byte FutureTradeFlags = 1 << 4;

    /// <summary>
    ///  Length of Trade Flags in bytes
    /// </summary>
    public const int Length = 1;
}

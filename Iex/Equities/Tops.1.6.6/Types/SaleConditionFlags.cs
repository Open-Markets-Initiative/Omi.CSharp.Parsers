namespace Iex.Tops;

using System.Runtime.CompilerServices;

/// <summary>
///  Sale Condition Flags: Bitfield
/// </summary>

public sealed class SaleConditionFlags
{
    /// <summary>
    ///  Intermarket Sweep
    /// </summary>
    public const byte IntermarketSweep = 1 << 0;

    /// <summary>
    ///  Extended Hours
    /// </summary>
    public const byte ExtendedHours = 1 << 1;

    /// <summary>
    ///  Odd Lot
    /// </summary>
    public const byte OddLot = 1 << 2;

    /// <summary>
    ///  Trade Through Exempt
    /// </summary>
    public const byte TradeThroughExempt = 1 << 3;

    /// <summary>
    ///  Singleprice Cross Trade
    /// </summary>
    public const byte SinglepriceCrossTrade = 1 << 4;

    /// <summary>
    ///  Unused 3
    /// </summary>
    public const byte Unused3 = 1 << 5;

    /// <summary>
    ///  Length of Sale Condition Flags in bytes
    /// </summary>
    public const int Length = 1;
}

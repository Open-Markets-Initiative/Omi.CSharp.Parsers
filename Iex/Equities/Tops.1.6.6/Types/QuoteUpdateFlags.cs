namespace Iex.Tops;

using System.Runtime.CompilerServices;

/// <summary>
///  Quote Update Flags: Bitfield
/// </summary>

public sealed class QuoteUpdateFlags
{
    /// <summary>
    ///  Unused 4
    /// </summary>
    public const byte Unused4 = 1 << 0;

    /// <summary>
    ///  Symbol Availability
    /// </summary>
    public const byte SymbolAvailability = 1 << 4;

    /// <summary>
    ///  Market Session
    /// </summary>
    public const byte MarketSession = 1 << 5;

    /// <summary>
    ///  Unused 2
    /// </summary>
    public const byte Unused2 = 1 << 6;

    /// <summary>
    ///  Length of Quote Update Flags in bytes
    /// </summary>
    public const int Length = 1;
}

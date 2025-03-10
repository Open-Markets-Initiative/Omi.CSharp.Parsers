namespace Cme.Streamlined;

using System.Runtime.CompilerServices;

/// <summary>
///  Settl Price Type: Bitfield
/// </summary>

public sealed class SettlPriceType
{
    /// <summary>
    ///  Null Value
    /// </summary>
    public const byte NullValue = 1 << 0;

    /// <summary>
    ///  Reserved Bits
    /// </summary>
    public const byte ReservedBits = 1 << 1;

    /// <summary>
    ///  Rounded
    /// </summary>
    public const byte Rounded = 1 << 5;

    /// <summary>
    ///  Actual
    /// </summary>
    public const byte Actual = 1 << 6;

    /// <summary>
    ///  Final Daily
    /// </summary>
    public const byte FinalDaily = 1 << 7;

    /// <summary>
    ///  Length of Settl Price Type in bytes
    /// </summary>
    public const int Length = 1;
}

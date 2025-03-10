using System.Runtime.CompilerServices;

namespace Siac.Recipient;

/// <summary>
///  Expiration Day: Contains Hex 0 X 01 To 0 X 1f Decimal 1 To 31 Indicating The Day Of The Month The Series Expires
/// </summary>

public struct ExpirationDay
{
    /// <summary>
    ///  Length of Expiration Day in bytes
    /// </summary>
    public const int Size = 1;

    /// <summary>
    ///  Read Expiration Day
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public byte Decode()
        => Byte;

    /// <summary>
    ///  Write Expiration Day
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(byte value)
        => Byte = value;

    /// <summary>
    ///  Expiration Day as string
    /// </summary>
    public readonly override string ToString()
        => $"{Decode()}";

    /// <summary>
    ///  Underlying byte
    /// </summary>
    internal byte Byte;
}

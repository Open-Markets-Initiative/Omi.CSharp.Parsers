using System.Runtime.CompilerServices;

namespace Siac.Recipient;

/// <summary>
///  Expiration Year: Contains Hex 0 X 00 To 0 X 63 Decimal 0 To 99 Represents The Year Starting With Year 2000
/// </summary>

public struct ExpirationYear
{
    /// <summary>
    ///  Length of Expiration Year in bytes
    /// </summary>
    public const int Size = 1;

    /// <summary>
    ///  Read Expiration Year
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public byte Decode()
        => Byte;

    /// <summary>
    ///  Write Expiration Year
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(byte value)
        => Byte = value;

    /// <summary>
    ///  Expiration Year as string
    /// </summary>
    public readonly override string ToString()
        => $"{Decode()}";

    /// <summary>
    ///  Underlying byte
    /// </summary>
    internal byte Byte;
}

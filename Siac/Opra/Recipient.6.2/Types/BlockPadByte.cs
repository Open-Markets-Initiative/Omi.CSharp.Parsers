using System.Runtime.CompilerServices;

namespace Siac.Recipient;

/// <summary>
///  Block Pad Byte: Block Pad Byte
/// </summary>

public struct BlockPadByte
{
    /// <summary>
    ///  Length of Block Pad Byte in bytes
    /// </summary>
    public const int Size = 1;

    /// <summary>
    ///  Read Block Pad Byte
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public byte Decode()
        => Byte;

    /// <summary>
    ///  Write Block Pad Byte
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(byte value)
        => Byte = value;

    /// <summary>
    ///  Block Pad Byte as string
    /// </summary>
    public readonly override string ToString()
        => $"{Decode()}";

    /// <summary>
    ///  Underlying byte
    /// </summary>
    internal byte Byte;
}

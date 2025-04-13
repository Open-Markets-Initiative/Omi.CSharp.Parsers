using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient;

/// <summary>
///  Nanoseconds: The Nanosecond Portion Of The Time Currently Rounded To The Nearest Microsecond
/// </summary>

public struct Nanoseconds
{
    /// <summary>
    ///  Size of Nanoseconds in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Nanoseconds value
    /// </summary>
    public readonly uint Value
        => Decode();

    /// <summary>
    ///  Read Nanoseconds
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly uint Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Nanoseconds
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(uint value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Nanoseconds as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal uint Underlying;
}

using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView;
/// <summary>
///  Timestamp: Nanoseconds since midnight.
/// </summary>

public struct Timestamp
{
    /// <summary>
    ///  Size of Timestamp in bytes
    /// </summary>
    public const int Size = 6;

    /// <summary>
    ///  Timestamp value
    /// </summary>
    public readonly fixed byte Value
        => Decode();

    /// <summary>
    ///  Read Timestamp
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly fixed byte Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Timestamp
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(fixed byte value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Timestamp as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal fixed byte Underlying;
}

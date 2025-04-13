using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Sequence Within Millis: Can be used in conjunction with TransactDateTime field for sequence of deals within same milliseconds time.
/// </summary>

public struct SequenceWithinMillis
{
    /// <summary>
    ///  Size of Sequence Within Millis in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Sequence Within Millis value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Sequence Within Millis
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Sequence Within Millis
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Sequence Within Millis as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

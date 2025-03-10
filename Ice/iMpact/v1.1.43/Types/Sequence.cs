using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;
/// <summary>
///  Sequence: TODO
/// </summary>

public struct Sequence
{
    /// <summary>
    ///  Size of Sequence in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Sequence value
    /// </summary>
    public readonly uint Value
        => Decode();

    /// <summary>
    ///  Read Sequence
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly uint Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Sequence
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(uint value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Sequence as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal uint Underlying;
}

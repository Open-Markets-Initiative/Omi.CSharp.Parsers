using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient;
/// <summary>
///  Block Sequence Number: Packet Sequence Number
/// </summary>

public struct BlockSequenceNumber
{
    /// <summary>
    ///  Size of Block Sequence Number in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Block Sequence Number value
    /// </summary>
    public readonly uint Value
        => Decode();

    /// <summary>
    ///  Read Block Sequence Number
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly uint Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Block Sequence Number
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(uint value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Block Sequence Number as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal uint Underlying;
}

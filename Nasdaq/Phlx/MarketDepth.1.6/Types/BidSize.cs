using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Bid Size: The bid contracts of the new quote.
/// </summary>

public struct BidSize
{
    /// <summary>
    ///  Size of Bid Size in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Bid Size value
    /// </summary>
    public readonly uint Value
        => Decode();

    /// <summary>
    ///  Read Bid Size
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly uint Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Bid Size
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(uint value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Bid Size as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal uint Underlying;
}

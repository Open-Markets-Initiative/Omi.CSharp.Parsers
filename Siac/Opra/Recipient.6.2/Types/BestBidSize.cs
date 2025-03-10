using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient;
/// <summary>
///  Best Bid Size: The Best Bid Size Identifies The Number Of Contracts Being Bought For An Option At The Best Bid Price
/// </summary>

public struct BestBidSize
{
    /// <summary>
    ///  Size of Best Bid Size in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Best Bid Size value
    /// </summary>
    public readonly uint Value
        => Decode();

    /// <summary>
    ///  Read Best Bid Size
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly uint Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Best Bid Size
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(uint value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Best Bid Size as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal uint Underlying;
}

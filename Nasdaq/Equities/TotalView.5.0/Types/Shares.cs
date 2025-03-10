using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView;
/// <summary>
///  Shares: The total number of shares associated with the order being added to the book.
/// </summary>

public struct Shares
{
    /// <summary>
    ///  Size of Shares in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Shares value
    /// </summary>
    public readonly uint Value
        => Decode();

    /// <summary>
    ///  Read Shares
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly uint Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Shares
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(uint value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Shares as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal uint Underlying;
}

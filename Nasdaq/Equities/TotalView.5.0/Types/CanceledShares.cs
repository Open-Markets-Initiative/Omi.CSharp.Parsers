using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Canceled Shares: The number of shares being removed from the display size of the order as the result of a cancellation.
/// </summary>

public struct CanceledShares
{
    /// <summary>
    ///  Size of Canceled Shares in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Canceled Shares value
    /// </summary>
    public readonly uint Value
        => Decode();

    /// <summary>
    ///  Read Canceled Shares
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly uint Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Canceled Shares
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(uint value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Canceled Shares as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal uint Underlying;
}

using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView;
/// <summary>
///  Imbalance Shares: The number of shares not paired at the Current Reference Price.
/// </summary>

public struct ImbalanceShares
{
    /// <summary>
    ///  Size of Imbalance Shares in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  Imbalance Shares value
    /// </summary>
    public readonly ulong Value
        => Decode();

    /// <summary>
    ///  Read Imbalance Shares
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly ulong Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Imbalance Shares
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(ulong value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Imbalance Shares as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal ulong Underlying;
}

using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Cross Shares: The number of shares matched in the
/// </summary>

public struct CrossShares
{
    /// <summary>
    ///  Size of Cross Shares in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  Cross Shares value
    /// </summary>
    public readonly ulong Value
        => Decode();

    /// <summary>
    ///  Read Cross Shares
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly ulong Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Cross Shares
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(ulong value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Cross Shares as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal ulong Underlying;
}

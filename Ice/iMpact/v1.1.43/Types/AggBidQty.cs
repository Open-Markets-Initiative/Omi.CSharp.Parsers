using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Agg Bid Qty: Aggregate bid quantity
/// </summary>

public struct AggBidQty
{
    /// <summary>
    ///  Size of Agg Bid Qty in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Agg Bid Qty value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Agg Bid Qty
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Agg Bid Qty
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Agg Bid Qty as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Threshold Imbalance Qty
/// </summary>

public struct ThresholdImbalanceQty
{
    /// <summary>
    ///  Size of Threshold Imbalance Qty in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Threshold Imbalance Qty value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Threshold Imbalance Qty
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Threshold Imbalance Qty
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Threshold Imbalance Qty as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

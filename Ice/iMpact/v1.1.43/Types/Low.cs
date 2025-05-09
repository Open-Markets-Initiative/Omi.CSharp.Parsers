using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Low: DealPriceDenominator for the market should be applied to get the real price.
/// </summary>

public struct Low
{
    /// <summary>
    ///  Size of Low in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  Low value
    /// </summary>
    public readonly long Value
        => Decode();

    /// <summary>
    ///  Read Low
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly long Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Low
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(long value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Low as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal long Underlying;
}

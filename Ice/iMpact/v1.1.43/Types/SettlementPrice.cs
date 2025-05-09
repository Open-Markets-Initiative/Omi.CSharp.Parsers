using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Settlement Price: SettlePriceDenominator for the market should be applied to get the real settlement price.
/// </summary>

public struct SettlementPrice
{
    /// <summary>
    ///  Size of Settlement Price in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  Settlement Price value
    /// </summary>
    public readonly long Value
        => Decode();

    /// <summary>
    ///  Read Settlement Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly long Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Settlement Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(long value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Settlement Price as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal long Underlying;
}

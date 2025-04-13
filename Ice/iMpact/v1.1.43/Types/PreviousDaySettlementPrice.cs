using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Previous Day Settlement Price: SettlePriceDenominator for the market should be applied to get the real previous day settlement price.
/// </summary>

public struct PreviousDaySettlementPrice
{
    /// <summary>
    ///  Size of Previous Day Settlement Price in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  Previous Day Settlement Price value
    /// </summary>
    public readonly long Value
        => Decode();

    /// <summary>
    ///  Read Previous Day Settlement Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly long Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Previous Day Settlement Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(long value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Previous Day Settlement Price as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal long Underlying;
}

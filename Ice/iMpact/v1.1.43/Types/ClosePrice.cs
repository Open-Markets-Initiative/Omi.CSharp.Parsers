using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Close Price: DealPriceDenominator for the market should be applied to get the real price.
/// </summary>

public struct ClosePrice
{
    /// <summary>
    ///  Size of Close Price in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  Close Price value
    /// </summary>
    public readonly long Value
        => Decode();

    /// <summary>
    ///  Read Close Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly long Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Close Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(long value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Close Price as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal long Underlying;
}

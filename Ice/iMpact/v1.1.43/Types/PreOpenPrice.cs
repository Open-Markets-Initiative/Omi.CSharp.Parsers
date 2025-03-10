using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;
/// <summary>
///  Pre Open Price: DealPriceDenominator for the market should be applied to get the real price.
/// </summary>

public struct PreOpenPrice
{
    /// <summary>
    ///  Size of Pre Open Price in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  Pre Open Price value
    /// </summary>
    public readonly long Value
        => Decode();

    /// <summary>
    ///  Read Pre Open Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly long Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Pre Open Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(long value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Pre Open Price as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal long Underlying;
}

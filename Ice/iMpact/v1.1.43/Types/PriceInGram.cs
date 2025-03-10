using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;
/// <summary>
///  Price In Gram: Auctioneers price in gram for the round in specified currency
/// </summary>

public struct PriceInGram
{
    /// <summary>
    ///  Size of Price In Gram in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  Price In Gram value
    /// </summary>
    public readonly long Value
        => Decode();

    /// <summary>
    ///  Read Price In Gram
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly long Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Price In Gram
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(long value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Price In Gram as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal long Underlying;
}

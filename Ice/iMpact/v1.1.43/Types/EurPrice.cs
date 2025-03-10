using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;
/// <summary>
///  Eur Price: Obsolete. The price will be published via the Fixing Indicative Price Message.
/// </summary>

public struct EurPrice
{
    /// <summary>
    ///  Size of Eur Price in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  Eur Price value
    /// </summary>
    public readonly long Value
        => Decode();

    /// <summary>
    ///  Read Eur Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly long Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Eur Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(long value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Eur Price as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal long Underlying;
}

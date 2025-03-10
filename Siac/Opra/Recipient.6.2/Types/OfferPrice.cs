using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient;
/// <summary>
///  Offer Price: Represents The Price At Which A Seller Is Offering To Sell An Option
/// </summary>

public struct OfferPrice
{
    /// <summary>
    ///  Size of Offer Price in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Offer Price value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Offer Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Offer Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Offer Price as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Product Id: ID of the product that the contract/market is under.
/// </summary>

public struct ProductId
{
    /// <summary>
    ///  Size of Product Id in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Product Id value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Product Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Product Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Product Id as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

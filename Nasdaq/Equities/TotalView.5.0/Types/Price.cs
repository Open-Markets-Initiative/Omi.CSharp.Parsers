using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Price: The display price of the new order.  Refer to Data Types for field processing notes.
/// </summary>

public struct Price
{
    /// <summary>
    ///  Decimal place factor for Price
    /// </summary>
    public const uint Factor = 10000;

    /// <summary>
    ///  Size of Price in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Price value
    /// </summary>
    public readonly uint Value
        => Decode();

    /// <summary>
    ///  Read Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly uint Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying) / Factor;

    /// <summary>
    ///  Write Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(uint value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value) * Factor;

    /// <summary>
    ///  Price as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal uint Underlying;
}

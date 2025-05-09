using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Short Bid Price: NOTE: When converted to a decimal format, this price is in fixed point format with 3 whole number places followed by 2 decimal digits. The display bid price of the new quote.
/// </summary>

public struct ShortBidPrice
{
    /// <summary>
    ///  Decimal place factor for Short Bid Price
    /// </summary>
    public const short Factor = 100;

    /// <summary>
    ///  Size of Short Bid Price in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Short Bid Price value
    /// </summary>
    public readonly short Value
        => Decode();

    /// <summary>
    ///  Read Short Bid Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly short Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying) / Factor;

    /// <summary>
    ///  Write Short Bid Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(short value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value) * Factor;

    /// <summary>
    ///  Short Bid Price as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal short Underlying;
}

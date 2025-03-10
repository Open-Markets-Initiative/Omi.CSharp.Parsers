using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Bid Price: The display bid price of the new quote.  NOTE: When converted to a decimal format, this price is in fixed point format with 6 whole number places followed by 4 decimal digits.
/// </summary>

public struct BidPrice
{
    /// <summary>
    ///  Decimal place factor for Bid Price
    /// </summary>
    public const int Factor = 10000;

    /// <summary>
    ///  Size of Bid Price in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Bid Price value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Bid Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying) / Factor;

    /// <summary>
    ///  Write Bid Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value) * Factor;

    /// <summary>
    ///  Bid Price as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Ask Price: NOTE: When converted to a decimal format, this price is in fixed point format with 6 whole number places followed by 4 decimal digits. The display ask price of the new quote.
/// </summary>

public struct AskPrice
{
    /// <summary>
    ///  Decimal place factor for Ask Price
    /// </summary>
    public const int Factor = 10000;

    /// <summary>
    ///  Size of Ask Price in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Ask Price value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Ask Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying) / Factor;

    /// <summary>
    ///  Write Ask Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value) * Factor;

    /// <summary>
    ///  Ask Price as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

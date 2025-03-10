using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Short Ask Price: The display ask price of the new quote.
/// </summary>

public struct ShortAskPrice
{
    /// <summary>
    ///  Decimal place factor for Short Ask Price
    /// </summary>
    public const short Factor = 100;

    /// <summary>
    ///  Size of Short Ask Price in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Short Ask Price value
    /// </summary>
    public readonly short Value
        => Decode();

    /// <summary>
    ///  Read Short Ask Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly short Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying) / Factor;

    /// <summary>
    ///  Write Short Ask Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(short value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value) * Factor;

    /// <summary>
    ///  Short Ask Price as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal short Underlying;
}

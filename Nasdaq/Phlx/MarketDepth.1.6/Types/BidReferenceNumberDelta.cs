using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Bid Reference Number Delta: The bid reference number delta associated with the new quote.
/// </summary>

public struct BidReferenceNumberDelta
{
    /// <summary>
    ///  Size of Bid Reference Number Delta in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Bid Reference Number Delta value
    /// </summary>
    public readonly uint Value
        => Decode();

    /// <summary>
    ///  Read Bid Reference Number Delta
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly uint Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Bid Reference Number Delta
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(uint value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Bid Reference Number Delta as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal uint Underlying;
}

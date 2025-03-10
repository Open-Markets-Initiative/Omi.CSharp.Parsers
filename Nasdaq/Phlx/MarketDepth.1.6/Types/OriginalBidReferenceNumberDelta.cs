using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth;
/// <summary>
///  Original Bid Reference Number Delta: The original bid reference number delta associated with the order being replaced.
/// </summary>

public struct OriginalBidReferenceNumberDelta
{
    /// <summary>
    ///  Size of Original Bid Reference Number Delta in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Original Bid Reference Number Delta value
    /// </summary>
    public readonly uint Value
        => Decode();

    /// <summary>
    ///  Read Original Bid Reference Number Delta
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly uint Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Original Bid Reference Number Delta
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(uint value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Original Bid Reference Number Delta as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal uint Underlying;
}

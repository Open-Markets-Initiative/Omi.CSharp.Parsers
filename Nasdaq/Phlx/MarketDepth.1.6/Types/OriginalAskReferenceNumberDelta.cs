using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Original Ask Reference Number Delta: The original ask reference number delta associated with the order being replaced.
/// </summary>

public struct OriginalAskReferenceNumberDelta
{
    /// <summary>
    ///  Size of Original Ask Reference Number Delta in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Original Ask Reference Number Delta value
    /// </summary>
    public readonly uint Value
        => Decode();

    /// <summary>
    ///  Read Original Ask Reference Number Delta
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly uint Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Original Ask Reference Number Delta
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(uint value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Original Ask Reference Number Delta as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal uint Underlying;
}

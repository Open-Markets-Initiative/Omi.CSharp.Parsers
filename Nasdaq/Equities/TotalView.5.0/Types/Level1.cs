using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Level 1: Denotes the MWCB Level 1 Value.
/// </summary>

public struct Level1
{
    /// <summary>
    ///  Decimal place factor for Level 1
    /// </summary>
    public const ulong Factor = 100000000;

    /// <summary>
    ///  Size of Level 1 in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  Level 1 value
    /// </summary>
    public readonly ulong Value
        => Decode();

    /// <summary>
    ///  Read Level 1
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly ulong Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying) / Factor;

    /// <summary>
    ///  Write Level 1
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(ulong value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value) * Factor;

    /// <summary>
    ///  Level 1 as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal ulong Underlying;
}

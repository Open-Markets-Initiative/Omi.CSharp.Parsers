using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Original Order Reference Number: The original reference number of the order being replaced.
/// </summary>

public struct OriginalOrderReferenceNumber
{
    /// <summary>
    ///  Size of Original Order Reference Number in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  Original Order Reference Number value
    /// </summary>
    public readonly ulong Value
        => Decode();

    /// <summary>
    ///  Read Original Order Reference Number
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly ulong Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Original Order Reference Number
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(ulong value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Original Order Reference Number as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal ulong Underlying;
}

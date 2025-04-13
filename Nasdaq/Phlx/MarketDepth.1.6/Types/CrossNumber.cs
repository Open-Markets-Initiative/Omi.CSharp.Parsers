using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Cross Number: Trade Group Id. Ties together all trades of a given atomic transaction in the matching engine.
/// </summary>

public struct CrossNumber
{
    /// <summary>
    ///  Size of Cross Number in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Cross Number value
    /// </summary>
    public readonly uint Value
        => Decode();

    /// <summary>
    ///  Read Cross Number
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly uint Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Cross Number
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(uint value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Cross Number as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal uint Underlying;
}

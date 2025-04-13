using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Volatility: Apply 2 as the denominator to get the real value. For example, volatility of 3.00 will be sent as 300.
/// </summary>

public struct Volatility
{
    /// <summary>
    ///  Size of Volatility in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  Volatility value
    /// </summary>
    public readonly long Value
        => Decode();

    /// <summary>
    ///  Read Volatility
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly long Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Volatility
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(long value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Volatility as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal long Underlying;
}

using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Reserved: Reserved for future use
/// </summary>

public struct Reserved
{
    /// <summary>
    ///  Size of Reserved in bytes
    /// </summary>
    public const int Size = 3;

    /// <summary>
    ///  Reserved value
    /// </summary>
    public readonly fixed byte Value
        => Decode();

    /// <summary>
    ///  Read Reserved
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly fixed byte Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Reserved
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(fixed byte value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Reserved as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal fixed byte Underlying;
}

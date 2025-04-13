using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Min Options Price: Minimum premium price for the option.
/// </summary>

public struct MinOptionsPrice
{
    /// <summary>
    ///  Size of Min Options Price in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  Min Options Price value
    /// </summary>
    public readonly long Value
        => Decode();

    /// <summary>
    ///  Read Min Options Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly long Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Min Options Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(long value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Min Options Price as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal long Underlying;
}

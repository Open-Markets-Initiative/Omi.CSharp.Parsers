using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;
/// <summary>
///  Leg Ratio Price Numerator: Leg Ratio Price Numerator
/// </summary>

public struct LegRatioPriceNumerator
{
    /// <summary>
    ///  Size of Leg Ratio Price Numerator in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Leg Ratio Price Numerator value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Leg Ratio Price Numerator
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Leg Ratio Price Numerator
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Leg Ratio Price Numerator as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

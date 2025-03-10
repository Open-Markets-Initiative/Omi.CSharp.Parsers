using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;
/// <summary>
///  Leg Ratio Qty Numerator: Leg Ratio Qty Numerator
/// </summary>

public struct LegRatioQtyNumerator
{
    /// <summary>
    ///  Size of Leg Ratio Qty Numerator in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Leg Ratio Qty Numerator value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Leg Ratio Qty Numerator
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Leg Ratio Qty Numerator
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Leg Ratio Qty Numerator as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

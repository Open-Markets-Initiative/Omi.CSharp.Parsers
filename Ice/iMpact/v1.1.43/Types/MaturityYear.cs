using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;
/// <summary>
///  Maturity Year: 4 digit year
/// </summary>

public struct MaturityYear
{
    /// <summary>
    ///  Size of Maturity Year in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Maturity Year value
    /// </summary>
    public readonly short Value
        => Decode();

    /// <summary>
    ///  Read Maturity Year
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly short Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Maturity Year
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(short value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Maturity Year as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal short Underlying;
}

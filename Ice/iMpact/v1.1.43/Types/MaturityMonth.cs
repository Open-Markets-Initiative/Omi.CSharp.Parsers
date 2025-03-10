using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;
/// <summary>
///  Maturity Month: Month range 1-12
/// </summary>

public struct MaturityMonth
{
    /// <summary>
    ///  Size of Maturity Month in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Maturity Month value
    /// </summary>
    public readonly short Value
        => Decode();

    /// <summary>
    ///  Read Maturity Month
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly short Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Maturity Month
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(short value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Maturity Month as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal short Underlying;
}

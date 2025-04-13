using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Efp Volume
/// </summary>

public struct EfpVolume
{
    /// <summary>
    ///  Size of Efp Volume in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Efp Volume value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Efp Volume
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Efp Volume
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Efp Volume as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

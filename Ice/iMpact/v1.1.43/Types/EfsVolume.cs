using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;
/// <summary>
///  Efs Volume
/// </summary>

public struct EfsVolume
{
    /// <summary>
    ///  Size of Efs Volume in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Efs Volume value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Efs Volume
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Efs Volume
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Efs Volume as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

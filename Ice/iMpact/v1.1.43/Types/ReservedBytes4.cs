using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Reserved Bytes 4: Reserved for future use
/// </summary>

public struct ReservedBytes4
{
    /// <summary>
    ///  Size of Reserved Bytes 4 in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Reserved Bytes 4 value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Reserved Bytes 4
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Reserved Bytes 4
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Reserved Bytes 4 as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

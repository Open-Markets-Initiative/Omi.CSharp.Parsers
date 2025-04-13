using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Total Volume: N/A if set to -1
/// </summary>

public struct TotalVolume
{
    /// <summary>
    ///  Size of Total Volume in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Total Volume value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Total Volume
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Total Volume
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Total Volume as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

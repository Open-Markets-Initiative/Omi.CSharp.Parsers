using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Hedge Delta: Hedge Delta
/// </summary>

public struct HedgeDelta
{
    /// <summary>
    ///  Size of Hedge Delta in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Hedge Delta value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Hedge Delta
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Hedge Delta
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Hedge Delta as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Ipl Hold Duration: Hold duration, in milliseconds. N/A when IPLHoldNotifyType = ‘E’
/// </summary>

public struct IplHoldDuration
{
    /// <summary>
    ///  Size of Ipl Hold Duration in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Ipl Hold Duration value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Ipl Hold Duration
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Ipl Hold Duration
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Ipl Hold Duration as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

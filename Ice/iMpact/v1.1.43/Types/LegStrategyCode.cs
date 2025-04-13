using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Leg Strategy Code: Leg Strategy Code
/// </summary>

public struct LegStrategyCode
{
    /// <summary>
    ///  Size of Leg Strategy Code in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Leg Strategy Code value
    /// </summary>
    public readonly short Value
        => Decode();

    /// <summary>
    ///  Read Leg Strategy Code
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly short Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Leg Strategy Code
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(short value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Leg Strategy Code as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal short Underlying;
}

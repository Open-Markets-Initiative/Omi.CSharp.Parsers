using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Hedge Strategy Code: Hedge Strategy Code
/// </summary>

public struct HedgeStrategyCode
{
    /// <summary>
    ///  Size of Hedge Strategy Code in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Hedge Strategy Code value
    /// </summary>
    public readonly short Value
        => Decode();

    /// <summary>
    ///  Read Hedge Strategy Code
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly short Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Hedge Strategy Code
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(short value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Hedge Strategy Code as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal short Underlying;
}

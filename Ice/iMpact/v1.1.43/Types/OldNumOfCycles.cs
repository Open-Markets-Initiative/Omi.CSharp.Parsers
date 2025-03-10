using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;
/// <summary>
///  Old Num Of Cycles: Number of cycles for a contract.
/// </summary>

public struct OldNumOfCycles
{
    /// <summary>
    ///  Size of Old Num Of Cycles in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Old Num Of Cycles value
    /// </summary>
    public readonly short Value
        => Decode();

    /// <summary>
    ///  Read Old Num Of Cycles
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly short Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Old Num Of Cycles
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(short value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Old Num Of Cycles as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal short Underlying;
}

using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;
/// <summary>
///  Delta: Apply 2 as the denominator to get the real value. For example, delta of 3.00 will be sent as 300.
/// </summary>

public struct Delta
{
    /// <summary>
    ///  Size of Delta in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  Delta value
    /// </summary>
    public readonly long Value
        => Decode();

    /// <summary>
    ///  Read Delta
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly long Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Delta
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(long value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Delta as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal long Underlying;
}

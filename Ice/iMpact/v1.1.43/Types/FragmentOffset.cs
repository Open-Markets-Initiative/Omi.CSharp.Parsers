using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Fragment Offset: The index of the byte where this fragment starts within the total length of the fragmented message.
/// </summary>

public struct FragmentOffset
{
    /// <summary>
    ///  Size of Fragment Offset in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Fragment Offset value
    /// </summary>
    public readonly short Value
        => Decode();

    /// <summary>
    ///  Read Fragment Offset
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly short Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Fragment Offset
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(short value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Fragment Offset as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal short Underlying;
}

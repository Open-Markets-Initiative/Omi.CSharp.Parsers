using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Fragment Length: The number of bytes in this fragment
/// </summary>

public struct FragmentLength
{
    /// <summary>
    ///  Size of Fragment Length in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Fragment Length value
    /// </summary>
    public readonly short Value
        => Decode();

    /// <summary>
    ///  Read Fragment Length
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly short Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Fragment Length
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(short value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Fragment Length as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal short Underlying;
}

using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;
/// <summary>
///  Pre Open Volume: Indicative volume that would trade at the preOpenPrice
/// </summary>

public struct PreOpenVolume
{
    /// <summary>
    ///  Size of Pre Open Volume in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Pre Open Volume value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Pre Open Volume
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Pre Open Volume
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Pre Open Volume as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Open Interest Change
/// </summary>

public struct OpenInterestChange
{
    /// <summary>
    ///  Size of Open Interest Change in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Open Interest Change value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Open Interest Change
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Open Interest Change
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Open Interest Change as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

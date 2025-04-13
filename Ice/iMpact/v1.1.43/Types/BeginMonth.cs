using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Begin Month: Month range 1-12
/// </summary>

public struct BeginMonth
{
    /// <summary>
    ///  Size of Begin Month in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Begin Month value
    /// </summary>
    public readonly short Value
        => Decode();

    /// <summary>
    ///  Read Begin Month
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly short Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Begin Month
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(short value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Begin Month as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal short Underlying;
}

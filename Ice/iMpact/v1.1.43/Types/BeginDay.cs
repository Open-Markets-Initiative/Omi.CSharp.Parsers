using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;
/// <summary>
///  Begin Day
/// </summary>

public struct BeginDay
{
    /// <summary>
    ///  Size of Begin Day in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Begin Day value
    /// </summary>
    public readonly short Value
        => Decode();

    /// <summary>
    ///  Read Begin Day
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly short Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Begin Day
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(short value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Begin Day as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal short Underlying;
}

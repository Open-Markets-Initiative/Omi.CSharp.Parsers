using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView;
/// <summary>
///  Count: Number of messages to follow this header
/// </summary>

public struct Count
{
    /// <summary>
    ///  Size of Count in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Count value
    /// </summary>
    public readonly ushort Value
        => Decode();

    /// <summary>
    ///  Read Count
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly ushort Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Count
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(ushort value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Count as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal ushort Underlying;
}

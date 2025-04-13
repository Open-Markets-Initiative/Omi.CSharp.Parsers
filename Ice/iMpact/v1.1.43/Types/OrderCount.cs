using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Order Count: Number of all orders at the price level
/// </summary>

public struct OrderCount
{
    /// <summary>
    ///  Size of Order Count in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Order Count value
    /// </summary>
    public readonly short Value
        => Decode();

    /// <summary>
    ///  Read Order Count
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly short Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Order Count
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(short value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Order Count as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal short Underlying;
}

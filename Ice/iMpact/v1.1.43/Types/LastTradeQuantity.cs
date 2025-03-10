using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;
/// <summary>
///  Last Trade Quantity
/// </summary>

public struct LastTradeQuantity
{
    /// <summary>
    ///  Size of Last Trade Quantity in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Last Trade Quantity value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Last Trade Quantity
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Last Trade Quantity
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Last Trade Quantity as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

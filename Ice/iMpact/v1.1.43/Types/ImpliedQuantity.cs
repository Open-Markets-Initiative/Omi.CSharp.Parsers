using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;
/// <summary>
///  Implied Quantity: Quantity that were implied
/// </summary>

public struct ImpliedQuantity
{
    /// <summary>
    ///  Size of Implied Quantity in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Implied Quantity value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Implied Quantity
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Implied Quantity
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Implied Quantity as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

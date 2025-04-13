using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Lot Size: The lot size is minimum size of contracts in lots. It is multiplier to determine the total lots.
/// </summary>

public struct LotSize
{
    /// <summary>
    ///  Size of Lot Size in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Lot Size value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Lot Size
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Lot Size
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Lot Size as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

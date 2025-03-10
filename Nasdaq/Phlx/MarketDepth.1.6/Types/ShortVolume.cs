using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth;
/// <summary>
///  Short Volume: The total number of contracts of the new order being added to the book.
/// </summary>

public struct ShortVolume
{
    /// <summary>
    ///  Size of Short Volume in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Short Volume value
    /// </summary>
    public readonly ushort Value
        => Decode();

    /// <summary>
    ///  Read Short Volume
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly ushort Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Short Volume
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(ushort value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Short Volume as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal ushort Underlying;
}

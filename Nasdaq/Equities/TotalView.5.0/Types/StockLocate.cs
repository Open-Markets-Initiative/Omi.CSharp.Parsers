using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Stock Locate: Always 0
/// </summary>

public struct StockLocate
{
    /// <summary>
    ///  Size of Stock Locate in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Stock Locate value
    /// </summary>
    public readonly ushort Value
        => Decode();

    /// <summary>
    ///  Read Stock Locate
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly ushort Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Stock Locate
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(ushort value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Stock Locate as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal ushort Underlying;
}

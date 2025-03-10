using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView;
/// <summary>
///  Ipo Quotation Release Time: Denotes the IPO release time, in seconds since midnight, for quotation to the nearest second.
/// </summary>

public struct IpoQuotationReleaseTime
{
    /// <summary>
    ///  Size of Ipo Quotation Release Time in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Ipo Quotation Release Time value
    /// </summary>
    public readonly uint Value
        => Decode();

    /// <summary>
    ///  Read Ipo Quotation Release Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly uint Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Ipo Quotation Release Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(uint value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Ipo Quotation Release Time as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal uint Underlying;
}

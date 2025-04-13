using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Rfq System Id: System ID of the RFQ
/// </summary>

public struct RfqSystemId
{
    /// <summary>
    ///  Size of Rfq System Id in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  Rfq System Id value
    /// </summary>
    public readonly long Value
        => Decode();

    /// <summary>
    ///  Read Rfq System Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly long Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Rfq System Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(long value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Rfq System Id as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal long Underlying;
}

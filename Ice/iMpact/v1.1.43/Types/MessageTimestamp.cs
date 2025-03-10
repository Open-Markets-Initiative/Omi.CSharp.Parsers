using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;
/// <summary>
///  Message Timestamp: Date time of the RFQ; milliseconds since Jan 1st, 1970, 00:00:00 GMT
/// </summary>

public struct MessageTimestamp
{
    /// <summary>
    ///  Size of Message Timestamp in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  Message Timestamp value
    /// </summary>
    public readonly long Value
        => Decode();

    /// <summary>
    ///  Read Message Timestamp
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly long Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Message Timestamp
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(long value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Message Timestamp as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal long Underlying;
}

using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Trade Transaction Id: The value used to associate bundles of the same transaction. This value will be 0 when the transaction has no trade. The value will be -1 if the channel does not support sub-bundling.
/// </summary>

public struct TradeTransactionId
{
    /// <summary>
    ///  Size of Trade Transaction Id in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  Trade Transaction Id value
    /// </summary>
    public readonly long Value
        => Decode();

    /// <summary>
    ///  Read Trade Transaction Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly long Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Trade Transaction Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(long value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Trade Transaction Id as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal long Underlying;
}

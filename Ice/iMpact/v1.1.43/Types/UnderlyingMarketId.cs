using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;
/// <summary>
///  Underlying Market Id: Unique identifier of the underlying market
/// </summary>

public struct UnderlyingMarketId
{
    /// <summary>
    ///  Size of Underlying Market Id in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Underlying Market Id value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Underlying Market Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Underlying Market Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Underlying Market Id as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

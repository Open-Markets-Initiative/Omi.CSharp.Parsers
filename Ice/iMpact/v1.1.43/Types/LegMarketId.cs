using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Leg Market Id: Market Id of the futures leg
/// </summary>

public struct LegMarketId
{
    /// <summary>
    ///  Size of Leg Market Id in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Leg Market Id value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Leg Market Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Leg Market Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Leg Market Id as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

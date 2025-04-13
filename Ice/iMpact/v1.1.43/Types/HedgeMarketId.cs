using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Hedge Market Id: Market ID for the corresponding hedge market.
/// </summary>

public struct HedgeMarketId
{
    /// <summary>
    ///  Size of Hedge Market Id in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Hedge Market Id value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Hedge Market Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Hedge Market Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Hedge Market Id as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

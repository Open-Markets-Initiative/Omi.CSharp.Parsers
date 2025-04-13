using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Paired Contracts: The total number of contracts that are eligible to be matched at the Current Reference Price. Zero for Order Exposure notifications.
/// </summary>

public struct PairedContracts
{
    /// <summary>
    ///  Size of Paired Contracts in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Paired Contracts value
    /// </summary>
    public readonly uint Value
        => Decode();

    /// <summary>
    ///  Read Paired Contracts
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly uint Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Paired Contracts
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(uint value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Paired Contracts as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal uint Underlying;
}

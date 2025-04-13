using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Executed Contracts: The number of contracts executed.
/// </summary>

public struct ExecutedContracts
{
    /// <summary>
    ///  Size of Executed Contracts in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Executed Contracts value
    /// </summary>
    public readonly uint Value
        => Decode();

    /// <summary>
    ///  Read Executed Contracts
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly uint Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Executed Contracts
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(uint value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Executed Contracts as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal uint Underlying;
}

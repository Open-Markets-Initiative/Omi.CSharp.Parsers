using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient;
/// <summary>
///  Trade Identifier: For Future Use Filled With Hex 0 X 00
/// </summary>

public struct TradeIdentifier
{
    /// <summary>
    ///  Size of Trade Identifier in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Trade Identifier value
    /// </summary>
    public readonly uint Value
        => Decode();

    /// <summary>
    ///  Read Trade Identifier
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly uint Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Trade Identifier
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(uint value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Trade Identifier as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal uint Underlying;
}

using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth;
/// <summary>
///  Order Reference Number Delta: The unique reference number delta assigned to the new order. The order reference number is Increasing, but not necessarily sequential.
/// </summary>

public struct OrderReferenceNumberDelta
{
    /// <summary>
    ///  Size of Order Reference Number Delta in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Order Reference Number Delta value
    /// </summary>
    public readonly uint Value
        => Decode();

    /// <summary>
    ///  Read Order Reference Number Delta
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly uint Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Order Reference Number Delta
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(uint value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Order Reference Number Delta as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal uint Underlying;
}

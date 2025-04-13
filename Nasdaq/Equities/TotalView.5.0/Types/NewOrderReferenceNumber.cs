using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView;

/// <summary>
///  New Order Reference Number: The new reference number for this order at time of replacement. Please note that the NASDAQ system will use this new order reference number for all subsequent updates.
/// </summary>

public struct NewOrderReferenceNumber
{
    /// <summary>
    ///  Size of New Order Reference Number in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  New Order Reference Number value
    /// </summary>
    public readonly ulong Value
        => Decode();

    /// <summary>
    ///  Read New Order Reference Number
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly ulong Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write New Order Reference Number
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(ulong value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  New Order Reference Number as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal ulong Underlying;
}

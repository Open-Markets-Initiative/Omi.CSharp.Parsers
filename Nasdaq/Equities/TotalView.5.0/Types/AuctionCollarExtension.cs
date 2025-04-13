using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Auction Collar Extension: Indicates the number of the extensions to the Reopening Auction
/// </summary>

public struct AuctionCollarExtension
{
    /// <summary>
    ///  Size of Auction Collar Extension in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Auction Collar Extension value
    /// </summary>
    public readonly uint Value
        => Decode();

    /// <summary>
    ///  Read Auction Collar Extension
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly uint Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Auction Collar Extension
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(uint value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Auction Collar Extension as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal uint Underlying;
}

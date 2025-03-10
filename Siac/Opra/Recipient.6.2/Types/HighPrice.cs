using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient;
/// <summary>
///  High Price: Represents The Highest Price Paid For An Option During The Trading Day
/// </summary>

public struct HighPrice
{
    /// <summary>
    ///  Size of High Price in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  High Price value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read High Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write High Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  High Price as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

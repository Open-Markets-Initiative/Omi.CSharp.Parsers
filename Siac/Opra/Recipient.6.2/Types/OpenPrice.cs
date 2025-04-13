using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient;

/// <summary>
///  Open Price: Represents The First Price Paid For An Option During The Trading Day
/// </summary>

public struct OpenPrice
{
    /// <summary>
    ///  Size of Open Price in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Open Price value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Open Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Open Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Open Price as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

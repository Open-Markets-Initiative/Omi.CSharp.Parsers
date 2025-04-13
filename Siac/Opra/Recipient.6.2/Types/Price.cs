using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient;

/// <summary>
///  Price: Represents The Price At Which A Buyer Is Willing To Buy An Option
/// </summary>

public struct Price
{
    /// <summary>
    ///  Size of Price in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Price value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Price as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

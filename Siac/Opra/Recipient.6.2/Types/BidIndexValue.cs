using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient;

/// <summary>
///  Bid Index Value: The Bid Index Value Represents The Value Of The Indexs Calculation Formula Using The Current Bid Values Of The Component Securities
/// </summary>

public struct BidIndexValue
{
    /// <summary>
    ///  Size of Bid Index Value in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Bid Index Value value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Bid Index Value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Bid Index Value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Bid Index Value as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

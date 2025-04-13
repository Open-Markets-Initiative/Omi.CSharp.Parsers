using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient;

/// <summary>
///  Net Change: Represents The Change In The Price Of An Option From The Closing Price Of One Day To The Closing Price On The Next Day On Which The Option Is Traded
/// </summary>

public struct NetChange
{
    /// <summary>
    ///  Size of Net Change in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Net Change value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Read Net Change
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Net Change
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Net Change as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

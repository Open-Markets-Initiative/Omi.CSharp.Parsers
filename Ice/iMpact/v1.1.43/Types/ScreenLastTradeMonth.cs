using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;
/// <summary>
///  Screen Last Trade Month: Screen last trade month, range 1-12
/// </summary>

public struct ScreenLastTradeMonth
{
    /// <summary>
    ///  Size of Screen Last Trade Month in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Screen Last Trade Month value
    /// </summary>
    public readonly short Value
        => Decode();

    /// <summary>
    ///  Read Screen Last Trade Month
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly short Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Screen Last Trade Month
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(short value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Screen Last Trade Month as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal short Underlying;
}

using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Screen Last Trade Day: Screen last trade day of the month
/// </summary>

public struct ScreenLastTradeDay
{
    /// <summary>
    ///  Size of Screen Last Trade Day in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Screen Last Trade Day value
    /// </summary>
    public readonly short Value
        => Decode();

    /// <summary>
    ///  Read Screen Last Trade Day
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly short Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Screen Last Trade Day
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(short value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Screen Last Trade Day as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal short Underlying;
}

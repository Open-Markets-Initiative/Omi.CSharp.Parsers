using System.Runtime.CompilerServices;

namespace Cme.Streamlined;
/// <summary>
///  Md Entry Date: Indicates Market Data Entry Date
/// </summary>

public struct MdEntryDate
{
    /// <summary>
    ///  Fix Tag for Md Entry Date
    /// </summary>
    public const ushort FixTag = 272;

    /// <summary>
    ///  Sentinel null value for Md Entry Date
    /// </summary>
    public const int NoValue = 2147483647;

    /// <summary>
    ///  Size of Md Entry Date in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Md Entry Date value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Does Md Entry Date field contain a value?
    /// </summary>
    public readonly bool HasValue
        => Underlying != NoValue;

    /// <summary>
    ///  Read Md Entry Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => Underlying;

    /// <summary>
    ///  Try Read Md Entry Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool TryRead(out int value)
    {
        value = Decode();
        return HasValue;
    }

    /// <summary>
    ///  Write Md Entry Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = value;

    /// <summary>
    ///  Set Md Entry Date to unused
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Reset()
        => Encode(NoValue);

    /// <summary>
    ///  Md Entry Date as string
    /// </summary>
    public readonly override string ToString()
        => TryRead(out var value) ? $"{value}" : "Not Applicable";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

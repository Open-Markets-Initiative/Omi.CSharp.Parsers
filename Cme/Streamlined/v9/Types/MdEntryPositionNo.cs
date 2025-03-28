using System.Runtime.CompilerServices;

namespace Cme.Streamlined;
/// <summary>
///  Md Entry Position No: Position in the book.
/// </summary>

public struct MdEntryPositionNo
{
    /// <summary>
    ///  Fix Tag for Md Entry Position No
    /// </summary>
    public const ushort FixTag = 290;

    /// <summary>
    ///  Sentinel null value for Md Entry Position No
    /// </summary>
    public const int NoValue = 2147483647;

    /// <summary>
    ///  Size of Md Entry Position No in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Md Entry Position No value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Does Md Entry Position No field contain a value?
    /// </summary>
    public readonly bool HasValue
        => Underlying != NoValue;

    /// <summary>
    ///  Read Md Entry Position No
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => Underlying;

    /// <summary>
    ///  Try Read Md Entry Position No
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool TryRead(out int value)
    {
        value = Decode();
        return HasValue;
    }

    /// <summary>
    ///  Write Md Entry Position No
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = value;

    /// <summary>
    ///  Set Md Entry Position No to unused
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Reset()
        => Encode(NoValue);

    /// <summary>
    ///  Md Entry Position No as string
    /// </summary>
    public readonly override string ToString()
        => TryRead(out var value) ? $"{value}" : "Not Applicable";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

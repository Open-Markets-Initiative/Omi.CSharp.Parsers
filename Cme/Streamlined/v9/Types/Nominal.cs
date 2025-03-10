using System.Runtime.CompilerServices;

namespace Cme.Streamlined;
/// <summary>
///  Nominal: This is the notional value used to calculate NPV and Fixed and Floating Payment amounts
/// </summary>

public struct Nominal
{
    /// <summary>
    ///  Fix Tag for Nominal
    /// </summary>
    public const ushort FixTag = 9280;

    /// <summary>
    ///  Sentinel null value for Nominal
    /// </summary>
    public const ulong NoValue = 18446744073709551615;

    /// <summary>
    ///  Size of Nominal in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  Nominal value
    /// </summary>
    public readonly ulong Value
        => Decode();

    /// <summary>
    ///  Does Nominal field contain a value?
    /// </summary>
    public readonly bool HasValue
        => Underlying != NoValue;

    /// <summary>
    ///  Read Nominal
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly ulong Decode()
        => Underlying;

    /// <summary>
    ///  Try Read Nominal
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool TryRead(out ulong value)
    {
        value = Decode();
        return HasValue;
    }

    /// <summary>
    ///  Write Nominal
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(ulong value)
        => Underlying = value;

    /// <summary>
    ///  Set Nominal to unused
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Reset()
        => Encode(NoValue);

    /// <summary>
    ///  Nominal as string
    /// </summary>
    public readonly override string ToString()
        => TryRead(out var value) ? $"{value}" : "Not Applicable";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal ulong Underlying;
}

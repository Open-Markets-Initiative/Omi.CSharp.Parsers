using System.Runtime.CompilerServices;

namespace Cme.Streamlined;
/// <summary>
///  Leg Ratio Qty: The ratio of quantity for this individual leg relative to the entire multi-leg instrument.
/// </summary>

public struct LegRatioQty
{
    /// <summary>
    ///  Fix Tag for Leg Ratio Qty
    /// </summary>
    public const ushort FixTag = 623;

    /// <summary>
    ///  Sentinel null value for Leg Ratio Qty
    /// </summary>
    public const int NoValue = 2147483647;

    /// <summary>
    ///  Size of Leg Ratio Qty in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Leg Ratio Qty value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Does Leg Ratio Qty field contain a value?
    /// </summary>
    public readonly bool HasValue
        => Underlying != NoValue;

    /// <summary>
    ///  Read Leg Ratio Qty
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => Underlying;

    /// <summary>
    ///  Try Read Leg Ratio Qty
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool TryRead(out int value)
    {
        value = Decode();
        return HasValue;
    }

    /// <summary>
    ///  Write Leg Ratio Qty
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = value;

    /// <summary>
    ///  Set Leg Ratio Qty to unused
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Reset()
        => Encode(NoValue);

    /// <summary>
    ///  Leg Ratio Qty as string
    /// </summary>
    public readonly override string ToString()
        => TryRead(out var value) ? $"{value}" : "Not Applicable";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

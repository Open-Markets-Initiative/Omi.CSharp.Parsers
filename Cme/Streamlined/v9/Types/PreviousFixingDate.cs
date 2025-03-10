using System.Runtime.CompilerServices;

namespace Cme.Streamlined;
/// <summary>
///  Previous Fixing Date: Issue date for one leg of a multi-issue trade. It is the previous fixing date on the float leg.
/// </summary>

public struct PreviousFixingDate
{
    /// <summary>
    ///  Fix Tag for Previous Fixing Date
    /// </summary>
    public const ushort FixTag = 37501;

    /// <summary>
    ///  Sentinel null value for Previous Fixing Date
    /// </summary>
    public const ushort NoValue = 65535;

    /// <summary>
    ///  Size of Previous Fixing Date in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Previous Fixing Date value
    /// </summary>
    public readonly ushort Value
        => Decode();

    /// <summary>
    ///  Does Previous Fixing Date field contain a value?
    /// </summary>
    public readonly bool HasValue
        => Underlying != NoValue;

    /// <summary>
    ///  Read Previous Fixing Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly ushort Decode()
        => Underlying;

    /// <summary>
    ///  Try Read Previous Fixing Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool TryRead(out ushort value)
    {
        value = Decode();
        return HasValue;
    }

    /// <summary>
    ///  Write Previous Fixing Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(ushort value)
        => Underlying = value;

    /// <summary>
    ///  Set Previous Fixing Date to unused
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Reset()
        => Encode(NoValue);

    /// <summary>
    ///  Previous Fixing Date as string
    /// </summary>
    public readonly override string ToString()
        => TryRead(out var value) ? $"{value}" : "Not Applicable";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal ushort Underlying;
}

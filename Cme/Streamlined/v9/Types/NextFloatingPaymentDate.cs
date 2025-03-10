using System.Runtime.CompilerServices;

namespace Cme.Streamlined;
/// <summary>
///  Next Floating Payment Date: The date the next floating payment will be made
/// </summary>

public struct NextFloatingPaymentDate
{
    /// <summary>
    ///  Fix Tag for Next Floating Payment Date
    /// </summary>
    public const ushort FixTag = 38018;

    /// <summary>
    ///  Sentinel null value for Next Floating Payment Date
    /// </summary>
    public const ushort NoValue = 65535;

    /// <summary>
    ///  Size of Next Floating Payment Date in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Next Floating Payment Date value
    /// </summary>
    public readonly ushort Value
        => Decode();

    /// <summary>
    ///  Does Next Floating Payment Date field contain a value?
    /// </summary>
    public readonly bool HasValue
        => Underlying != NoValue;

    /// <summary>
    ///  Read Next Floating Payment Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly ushort Decode()
        => Underlying;

    /// <summary>
    ///  Try Read Next Floating Payment Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool TryRead(out ushort value)
    {
        value = Decode();
        return HasValue;
    }

    /// <summary>
    ///  Write Next Floating Payment Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(ushort value)
        => Underlying = value;

    /// <summary>
    ///  Set Next Floating Payment Date to unused
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Reset()
        => Encode(NoValue);

    /// <summary>
    ///  Next Floating Payment Date as string
    /// </summary>
    public readonly override string ToString()
        => TryRead(out var value) ? $"{value}" : "Not Applicable";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal ushort Underlying;
}

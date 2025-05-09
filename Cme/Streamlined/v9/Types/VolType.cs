using System.Runtime.CompilerServices;

namespace Cme.Streamlined;
/// <summary>
///  Vol Type: Volume types for end of day volume
/// </summary>

public struct VolType
{
    /// <summary>
    ///  Fix Tag for Vol Type
    /// </summary>
    public const ushort FixTag = 9705;

    /// <summary>
    ///  Sentinel null value for Vol Type
    /// </summary>
    public const ushort NoValue = 65535;

    /// <summary>
    ///  Size of Vol Type in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Vol Type value
    /// </summary>
    public readonly ushort Value
        => Decode();

    /// <summary>
    ///  Does Vol Type field contain a value?
    /// </summary>
    public readonly bool HasValue
        => Underlying != NoValue;

    /// <summary>
    ///  Read Vol Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly ushort Decode()
        => Underlying;

    /// <summary>
    ///  Try Read Vol Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool TryRead(out ushort value)
    {
        value = Decode();
        return HasValue;
    }

    /// <summary>
    ///  Write Vol Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(ushort value)
        => Underlying = value;

    /// <summary>
    ///  Set Vol Type to unused
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Reset()
        => Encode(NoValue);

    /// <summary>
    ///  Vol Type as string
    /// </summary>
    public readonly override string ToString()
        => TryRead(out var value) ? $"{value}" : "Not Applicable";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal ushort Underlying;
}

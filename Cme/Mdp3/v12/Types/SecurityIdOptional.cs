using System.Runtime.CompilerServices;

namespace Cme.Mdp3;
/// <summary>
///  Security Id Optional: If this tag is present, 35=f message is sent for the instrument
/// </summary>

public struct SecurityIdOptional
{
    /// <summary>
    ///  Fix Tag for Security Id Optional
    /// </summary>
    public const ushort FixTag = 48;

    /// <summary>
    ///  Sentinel null value for Security Id Optional
    /// </summary>
    public const int NoValue = 2147483647;

    /// <summary>
    ///  Size of Security Id Optional in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Security Id Optional value
    /// </summary>
    public readonly int Value
        => Decode();

    /// <summary>
    ///  Does Security Id Optional field contain a value?
    /// </summary>
    public readonly bool HasValue
        => Underlying != NoValue;

    /// <summary>
    ///  Read Security Id Optional
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly int Decode()
        => Underlying;

    /// <summary>
    ///  Try Read Security Id Optional
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool TryRead(out int value)
    {
        value = Decode();
        return HasValue;
    }

    /// <summary>
    ///  Write Security Id Optional
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(int value)
        => Underlying = value;

    /// <summary>
    ///  Set Security Id Optional to unused
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Reset()
        => Encode(NoValue);

    /// <summary>
    ///  Security Id Optional as string
    /// </summary>
    public readonly override string ToString()
        => TryRead(out var value) ? $"{value}" : "Not Applicable";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal int Underlying;
}

using System.Runtime.CompilerServices;

namespace Cme.Mdp3;

/// <summary>
///  Main Fraction: Price Denominator of Main Fraction
/// </summary>

public struct MainFraction
{
    /// <summary>
    ///  Fix Tag for Main Fraction
    /// </summary>
    public const ushort FixTag = 37702;

    /// <summary>
    ///  Sentinel null value for Main Fraction
    /// </summary>
    public const byte NoValue = 255;

    /// <summary>
    ///  Length of Main Fraction in bytes
    /// </summary>
    public const int Size = 1;

    /// <summary>
    ///  Read Main Fraction
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public byte Decode()
        => Byte;

    /// <summary>
    ///  Write Main Fraction
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(byte value)
        => Byte = value;

    /// <summary>
    ///  Main Fraction as string
    /// </summary>
    public readonly override string ToString()
        => $"{Decode()}";

    /// <summary>
    ///  Underlying byte
    /// </summary>
    internal byte Byte;
}

using System.Runtime.CompilerServices;

namespace Cme.Mdp3;

/// <summary>
///  Price Precision: Specifies price decimal precision for EBS instrument
/// </summary>

public struct PricePrecision
{
    /// <summary>
    ///  Fix Tag for Price Precision
    /// </summary>
    public const ushort FixTag = 2349;

    /// <summary>
    ///  Length of Price Precision in bytes
    /// </summary>
    public const int Size = 1;

    /// <summary>
    ///  Read Price Precision
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public byte Decode()
        => Byte;

    /// <summary>
    ///  Write Price Precision
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(byte value)
        => Byte = value;

    /// <summary>
    ///  Price Precision as string
    /// </summary>
    public readonly override string ToString()
        => $"{Decode()}";

    /// <summary>
    ///  Underlying byte
    /// </summary>
    internal byte Byte;
}

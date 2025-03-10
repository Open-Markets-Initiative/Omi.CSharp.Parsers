using System.Runtime.CompilerServices;

namespace Cme.Streamlined;

/// <summary>
///  Week: WW
/// </summary>

public struct Week
{
    /// <summary>
    ///  Sentinel null value for Week
    /// </summary>
    public const byte NoValue = 255;

    /// <summary>
    ///  Length of Week in bytes
    /// </summary>
    public const int Size = 1;

    /// <summary>
    ///  Read Week
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public byte Decode()
        => Byte;

    /// <summary>
    ///  Write Week
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(byte value)
        => Byte = value;

    /// <summary>
    ///  Week as string
    /// </summary>
    public readonly override string ToString()
        => $"{Decode()}";

    /// <summary>
    ///  Underlying byte
    /// </summary>
    internal byte Byte;
}

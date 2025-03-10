using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Number Of Special Fields: Number of Fields present on this message
/// </summary>

public struct NumberOfSpecialFields
{
    /// <summary>
    ///  Size of Number Of Special Fields in bytes
    /// </summary>
    public const int Size = 1;

    /// <summary>
    ///  Read Number Of Special Fields
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public sbyte Decode()
        => (sbyte)Byte;

    /// <summary>
    ///  Write Number Of Special Fields
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(sbyte value)
        => Byte = (byte)value;

    /// <summary>
    ///  Number Of Special Fields as string
    /// </summary>
    public readonly override string ToString()
        => $"{Decode()}";

    /// <summary>
    ///  Underlying byte
    /// </summary>
    internal byte Byte;
}

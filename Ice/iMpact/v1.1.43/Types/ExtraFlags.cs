using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Extra Flags: For Future use
/// </summary>

public struct ExtraFlags
{
    /// <summary>
    ///  Size of Extra Flags in bytes
    /// </summary>
    public const int Size = 1;

    /// <summary>
    ///  Read Extra Flags
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public sbyte Decode()
        => (sbyte)Byte;

    /// <summary>
    ///  Write Extra Flags
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(sbyte value)
        => Byte = (byte)value;

    /// <summary>
    ///  Extra Flags as string
    /// </summary>
    public readonly override string ToString()
        => $"{Decode()}";

    /// <summary>
    ///  Underlying byte
    /// </summary>
    internal byte Byte;
}

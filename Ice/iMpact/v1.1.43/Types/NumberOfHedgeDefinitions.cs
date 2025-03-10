using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Number Of Hedge Definitions: Number of hedge definitions
/// </summary>

public struct NumberOfHedgeDefinitions
{
    /// <summary>
    ///  Size of Number Of Hedge Definitions in bytes
    /// </summary>
    public const int Size = 1;

    /// <summary>
    ///  Read Number Of Hedge Definitions
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public sbyte Decode()
        => (sbyte)Byte;

    /// <summary>
    ///  Write Number Of Hedge Definitions
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(sbyte value)
        => Byte = (byte)value;

    /// <summary>
    ///  Number Of Hedge Definitions as string
    /// </summary>
    public readonly override string ToString()
        => $"{Decode()}";

    /// <summary>
    ///  Underlying byte
    /// </summary>
    internal byte Byte;
}

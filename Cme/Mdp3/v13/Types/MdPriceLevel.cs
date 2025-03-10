using System.Runtime.CompilerServices;

namespace Cme.Mdp3;

/// <summary>
///  Md Price Level: Aggregate book level
/// </summary>

public struct MdPriceLevel
{
    /// <summary>
    ///  Fix Tag for Md Price Level
    /// </summary>
    public const ushort FixTag = 1023;

    /// <summary>
    ///  Length of Md Price Level in bytes
    /// </summary>
    public const int Size = 1;

    /// <summary>
    ///  Read Md Price Level
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public byte Decode()
        => Byte;

    /// <summary>
    ///  Write Md Price Level
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(byte value)
        => Byte = value;

    /// <summary>
    ///  Md Price Level as string
    /// </summary>
    public readonly override string ToString()
        => $"{Decode()}";

    /// <summary>
    ///  Underlying byte
    /// </summary>
    internal byte Byte;
}

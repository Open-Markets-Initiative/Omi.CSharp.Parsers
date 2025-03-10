using System.Runtime.CompilerServices;

namespace Cme.Mdp3;

/// <summary>
///  Num In Group
/// </summary>

public struct NumInGroup
{
    /// <summary>
    ///  Length of Num In Group in bytes
    /// </summary>
    public const int Size = 1;

    /// <summary>
    ///  Read Num In Group
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public byte Decode()
        => Byte;

    /// <summary>
    ///  Write Num In Group
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(byte value)
        => Byte = value;

    /// <summary>
    ///  Num In Group as string
    /// </summary>
    public readonly override string ToString()
        => $"{Decode()}";

    /// <summary>
    ///  Underlying byte
    /// </summary>
    internal byte Byte;
}

using System.Runtime.CompilerServices;

namespace Cme.Mdp3;

/// <summary>
///  Heart Bt Int: Heartbeat interval (seconds)
/// </summary>

public struct HeartBtInt
{
    /// <summary>
    ///  Fix Tag for Heart Bt Int
    /// </summary>
    public const ushort FixTag = 108;

    /// <summary>
    ///  Size of Heart Bt Int in bytes
    /// </summary>
    public const int Size = 1;

    /// <summary>
    ///  Read Heart Bt Int
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public sbyte Decode()
        => (sbyte)Byte;

    /// <summary>
    ///  Write Heart Bt Int
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(sbyte value)
        => Byte = (byte)value;

    /// <summary>
    ///  Heart Bt Int as string
    /// </summary>
    public readonly override string ToString()
        => $"{Decode()}";

    /// <summary>
    ///  Underlying byte
    /// </summary>
    internal byte Byte;
}

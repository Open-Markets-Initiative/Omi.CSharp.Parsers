using System.Runtime.CompilerServices;

namespace Cme.Mdp3;

/// <summary>
///  Lot Type: This tag is required to interpret the value in tag 1231-MinLotSize
/// </summary>

public struct LotType
{
    /// <summary>
    ///  Fix Tag for Lot Type
    /// </summary>
    public const ushort FixTag = 1093;

    /// <summary>
    ///  Size of Lot Type in bytes
    /// </summary>
    public const int Size = 1;

    /// <summary>
    ///  Read Lot Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public sbyte Decode()
        => (sbyte)Byte;

    /// <summary>
    ///  Write Lot Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(sbyte value)
        => Byte = (byte)value;

    /// <summary>
    ///  Lot Type as string
    /// </summary>
    public readonly override string ToString()
        => $"{Decode()}";

    /// <summary>
    ///  Underlying byte
    /// </summary>
    internal byte Byte;
}

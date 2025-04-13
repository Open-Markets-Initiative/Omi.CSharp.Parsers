using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Locate Code: Locate code identifying the security
/// </summary>

public struct LocateCode
{
    /// <summary>
    ///  Size of Locate Code in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Locate Code value
    /// </summary>
    public readonly ushort Value
        => Decode();

    /// <summary>
    ///  Read Locate Code
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly ushort Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Locate Code
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(ushort value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Locate Code as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal ushort Underlying;
}

using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Leg Ratio Obsolete: Number of futures contracts per increment quantity.
/// </summary>

public struct LegRatioObsolete
{
    /// <summary>
    ///  Size of Leg Ratio Obsolete in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Leg Ratio Obsolete value
    /// </summary>
    public readonly short Value
        => Decode();

    /// <summary>
    ///  Read Leg Ratio Obsolete
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly short Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Leg Ratio Obsolete
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(short value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Leg Ratio Obsolete as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal short Underlying;
}

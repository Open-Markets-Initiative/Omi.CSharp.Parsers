using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Hedge Delta Obsolete: Hedge Delta Obsolete
/// </summary>

public struct HedgeDeltaObsolete
{
    /// <summary>
    ///  Size of Hedge Delta Obsolete in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Hedge Delta Obsolete value
    /// </summary>
    public readonly short Value
        => Decode();

    /// <summary>
    ///  Read Hedge Delta Obsolete
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly short Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Hedge Delta Obsolete
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(short value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Hedge Delta Obsolete as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal short Underlying;
}

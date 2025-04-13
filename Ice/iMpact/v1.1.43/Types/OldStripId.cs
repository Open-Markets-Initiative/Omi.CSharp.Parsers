using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Old Strip Id: Not used. Kept here for backward compatibility. Client should use the new 4-byte StripID field.
/// </summary>

public struct OldStripId
{
    /// <summary>
    ///  Size of Old Strip Id in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Old Strip Id value
    /// </summary>
    public readonly short Value
        => Decode();

    /// <summary>
    ///  Read Old Strip Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly short Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Old Strip Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(short value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Old Strip Id as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal short Underlying;
}

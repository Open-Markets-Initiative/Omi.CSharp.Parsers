using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact;

/// <summary>
///  Options Expiration Month: Month Range
/// </summary>

public struct OptionsExpirationMonth
{
    /// <summary>
    ///  Size of Options Expiration Month in bytes
    /// </summary>
    public const int Size = 2;

    /// <summary>
    ///  Options Expiration Month value
    /// </summary>
    public readonly short Value
        => Decode();

    /// <summary>
    ///  Read Options Expiration Month
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly short Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Options Expiration Month
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(short value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Options Expiration Month as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal short Underlying;
}

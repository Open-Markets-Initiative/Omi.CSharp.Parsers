using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient;
/// <summary>
///  Open Interest Volume: Represents The Total Number Of Outstanding Option Contracts That Have Not Been Exercised And Have Not Yet Reached Expiration
/// </summary>

public struct OpenInterestVolume
{
    /// <summary>
    ///  Size of Open Interest Volume in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Open Interest Volume value
    /// </summary>
    public readonly uint Value
        => Decode();

    /// <summary>
    ///  Read Open Interest Volume
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly uint Decode()
        => BinaryPrimitives.ReverseEndianness(Underlying);

    /// <summary>
    ///  Write Open Interest Volume
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(uint value)
        => Underlying = BinaryPrimitives.ReverseEndianness(value);

    /// <summary>
    ///  Open Interest Volume as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal uint Underlying;
}

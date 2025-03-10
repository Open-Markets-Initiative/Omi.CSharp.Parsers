using System.Runtime.CompilerServices;

namespace Cme.Streamlined;
/// <summary>
///  Message Sequence Number: Packet Sequence Number
/// </summary>

public struct MessageSequenceNumber
{
    /// <summary>
    ///  Size of Message Sequence Number in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Message Sequence Number value
    /// </summary>
    public readonly uint Value
        => Decode();

    /// <summary>
    ///  Read Message Sequence Number
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly uint Decode()
        => Underlying;

    /// <summary>
    ///  Write Message Sequence Number
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(uint value)
        => Underlying = value;

    /// <summary>
    ///  Message Sequence Number as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal uint Underlying;
}

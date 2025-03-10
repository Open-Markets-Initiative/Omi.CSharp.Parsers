using System.Runtime.CompilerServices;

namespace Cme.Mdp3;
/// <summary>
///  Sending Time: Packet Sending Time
/// </summary>

public struct SendingTime
{
    /// <summary>
    ///  Size of Sending Time in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  Sending Time value
    /// </summary>
    public readonly ulong Value
        => Decode();

    /// <summary>
    ///  Read Sending Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly ulong Decode()
        => Underlying;

    /// <summary>
    ///  Write Sending Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(ulong value)
        => Underlying = value;

    /// <summary>
    ///  Sending Time as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal ulong Underlying;
}

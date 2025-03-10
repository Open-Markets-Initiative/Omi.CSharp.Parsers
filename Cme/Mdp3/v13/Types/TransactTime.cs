using System.Runtime.CompilerServices;

namespace Cme.Mdp3;
/// <summary>
///  Transact Time: Start of event processing time in number of nanoseconds since Unix epoch
/// </summary>

public struct TransactTime
{
    /// <summary>
    ///  Fix Tag for Transact Time
    /// </summary>
    public const ushort FixTag = 60;

    /// <summary>
    ///  Size of Transact Time in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  Transact Time value
    /// </summary>
    public readonly ulong Value
        => Decode();

    /// <summary>
    ///  Read Transact Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly ulong Decode()
        => Underlying;

    /// <summary>
    ///  Write Transact Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(ulong value)
        => Underlying = value;

    /// <summary>
    ///  Transact Time as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal ulong Underlying;
}

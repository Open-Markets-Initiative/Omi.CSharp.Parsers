using System.Runtime.CompilerServices;

namespace Eurex.Eobi;

/// <summary>
///  Trd Reg Ts Prev Time Priority
/// </summary>

public struct TrdRegTsPrevTimePriority
{
    /// <summary>
    ///  Sentinel null value for Trd Reg Ts Prev Time Priority
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Maximum value for Trd Reg Ts Prev Time Priority
    /// </summary>
    public const ulong Maximum = 18446744073709551614;

    /// <summary>
    ///  Minimum value for Trd Reg Ts Prev Time Priority
    /// </summary>
    public const ulong Minimum = 0;

    /// <summary>
    ///  Fix Tag for Trd Reg Ts Prev Time Priority
    /// </summary>
    public const ushort FixTag = 21026;

    /// <summary>
    ///  Size of Trd Reg Ts Prev Time Priority in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  Trd Reg Ts Prev Time Priority value
    /// </summary>
    public readonly DateTime Value
        => Decode();

    /// <summary>
    ///  Read Trd Reg Ts Prev Time Priority
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly DateTime Decode()
        => DateTime.UnixEpoch.AddTicks(Underlying / TimeSpan.NanosecondsPerTick);

    /// <summary>
    ///  Write Trd Reg Ts Prev Time Priority as Nanoseconds since Jan 1st, 1970, 00:00:00 GMT
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(DateTime timestamp)
        => Underlying = timestamp.Ticks * TimeSpan.NanosecondsPerTick;

    /// <summary>
    ///  Trd Reg Ts Prev Time Priority as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal long Underlying;
}

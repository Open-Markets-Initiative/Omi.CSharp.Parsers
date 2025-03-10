using System.Runtime.CompilerServices;

namespace Eurex.Eobi;

/// <summary>
///  Request Time
/// </summary>

public struct RequestTime
{
    /// <summary>
    ///  Sentinel null value for Request Time
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Maximum value for Request Time
    /// </summary>
    public const ulong Maximum = 18446744073709551614;

    /// <summary>
    ///  Minimum value for Request Time
    /// </summary>
    public const ulong Minimum = 0;

    /// <summary>
    ///  Fix Tag for Request Time
    /// </summary>
    public const ushort FixTag = 5979;

    /// <summary>
    ///  Size of Request Time in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  Request Time value
    /// </summary>
    public readonly DateTime Value
        => Decode();

    /// <summary>
    ///  Read Request Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly DateTime Decode()
        => DateTime.UnixEpoch.AddTicks(Underlying / TimeSpan.NanosecondsPerTick);

    /// <summary>
    ///  Write Request Time as Nanoseconds since Jan 1st, 1970, 00:00:00 GMT
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(DateTime timestamp)
        => Underlying = timestamp.Ticks * TimeSpan.NanosecondsPerTick;

    /// <summary>
    ///  Request Time as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal long Underlying;
}

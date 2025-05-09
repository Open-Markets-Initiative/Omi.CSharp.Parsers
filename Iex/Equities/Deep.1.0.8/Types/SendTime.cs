using System.Runtime.CompilerServices;

namespace Iex.Deep;

/// <summary>
///  Send Time: Send time of segment
/// </summary>

public struct SendTime
{
    /// <summary>
    ///  Size of Send Time in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  Send Time value
    /// </summary>
    public readonly DateTime Value
        => Decode();

    /// <summary>
    ///  Read Send Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly DateTime Decode()
        => DateTime.UnixEpoch.AddTicks(Underlying / TimeSpan.NanosecondsPerTick);

    /// <summary>
    ///  Write Send Time as Nanoseconds since Jan 1st, 1970, 00:00:00 GMT
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(DateTime timestamp)
        => Underlying = timestamp.Ticks * TimeSpan.NanosecondsPerTick;

    /// <summary>
    ///  Send Time as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal long Underlying;
}

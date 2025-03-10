using System.Runtime.CompilerServices;

namespace Eurex.Eobi;

/// <summary>
///  Exec Id
/// </summary>

public struct ExecId
{
    /// <summary>
    ///  Sentinel null value for Exec Id
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Maximum value for Exec Id
    /// </summary>
    public const ulong Maximum = 18446744073709551614;

    /// <summary>
    ///  Minimum value for Exec Id
    /// </summary>
    public const ulong Minimum = 0;

    /// <summary>
    ///  Fix Tag for Exec Id
    /// </summary>
    public const ushort FixTag = 17;

    /// <summary>
    ///  Size of Exec Id in bytes
    /// </summary>
    public const int Size = 8;

    /// <summary>
    ///  Exec Id value
    /// </summary>
    public readonly DateTime Value
        => Decode();

    /// <summary>
    ///  Read Exec Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly DateTime Decode()
        => DateTime.UnixEpoch.AddTicks(Underlying / TimeSpan.NanosecondsPerTick);

    /// <summary>
    ///  Write Exec Id as Nanoseconds since Jan 1st, 1970, 00:00:00 GMT
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(DateTime timestamp)
        => Underlying = timestamp.Ticks * TimeSpan.NanosecondsPerTick;

    /// <summary>
    ///  Exec Id as string
    /// </summary>
    public readonly override string ToString()
        => $"{Value}";

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal long Underlying;
}

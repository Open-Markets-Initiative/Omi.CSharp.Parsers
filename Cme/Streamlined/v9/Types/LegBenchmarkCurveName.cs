using System.Runtime.CompilerServices;

namespace Cme.Streamlined;

/// <summary>
///  Leg Benchmark Curve Name: Required for Floating Rate Leg. Floating rate reference.
/// </summary>

public unsafe struct LegBenchmarkCurveName
{
    /// <summary>
    ///  Fix Tag for Leg Benchmark Curve Name
    /// </summary>
    public const ushort FixTag = 677;

    /// <summary>
    ///  Size of Leg Benchmark Curve Name underlying field in bytes
    /// </summary>
    public const int Size = 5;

    /// <summary>
    ///  Length of Leg Benchmark Curve Name field
    /// </summary>
    public int Length
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (Bytes[0] == 0) { return 0; }
            if (Bytes[1] == 0) { return 1; }
            if (Bytes[2] == 0) { return 2; }
            if (Bytes[3] == 0) { return 3; }
            if (Bytes[4] == 0) { return 4; }

            return 5;
        }
    }

    /// <summary>
    ///  Leg Benchmark Curve Name value
    /// </summary>
    public readonly string Value
        => Decode(this);

    /// <summary>
    ///  Does Leg Benchmark Curve Name field contain a value?
    /// </summary>
    public bool HasValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Bytes[0] != 0; }
    }

    /// <summary>
    ///  Read Leg Benchmark Curve Name
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Decode(LegBenchmarkCurveName value)
        => new string((sbyte*)value.Bytes, 0, value.Length);

    /// <summary>
    ///  Try Read Leg Benchmark Curve Name
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryRead(out string value)
    {
        if (HasValue)
        {
            value = Decode(this);
            return true;
        }

        value = string.Empty;
        return false;
    }

    /// <summary>
    ///  Encode Leg Benchmark Curve Name
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(string value)
    {
        var length = value.Length;
        Bytes[0] = length > 0 ? (byte)value[0] : (byte)0;
        Bytes[1] = length > 1 ? (byte)value[1] : (byte)0;
        Bytes[2] = length > 2 ? (byte)value[2] : (byte)0;
        Bytes[3] = length > 3 ? (byte)value[3] : (byte)0;
        Bytes[4] = length > 4 ? (byte)value[4] : (byte)0;
    }

    /// <summary>
    ///  Leg Benchmark Curve Name as string
    /// </summary>
    public readonly override string ToString()
        => Value;

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal fixed byte Bytes[Size];
}

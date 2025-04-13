using System.Runtime.CompilerServices;

namespace Cme.Streamlined;

/// <summary>
///  Leg Pay Frequencey: Payment frequency of fixed and floating rates expresses as a period.
/// </summary>

public unsafe struct LegPayFrequencey
{
    /// <summary>
    ///  Fix Tag for Leg Pay Frequencey
    /// </summary>
    public const ushort FixTag = 37506;

    /// <summary>
    ///  Size of Leg Pay Frequencey underlying field in bytes
    /// </summary>
    public const int Size = 3;

    /// <summary>
    ///  Length of Leg Pay Frequencey field
    /// </summary>
    public int Length
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (Bytes[0] == 0) { return 0; }
            if (Bytes[1] == 0) { return 1; }
            if (Bytes[2] == 0) { return 2; }

            return 3;
        }
    }

    /// <summary>
    ///  Leg Pay Frequencey value
    /// </summary>
    public readonly string Value
        => Decode(this);

    /// <summary>
    ///  Does Leg Pay Frequencey field contain a value?
    /// </summary>
    public bool HasValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Bytes[0] != 0; }
    }

    /// <summary>
    ///  Read Leg Pay Frequencey
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Decode(LegPayFrequencey value)
        => new string((sbyte*)value.Bytes, 0, value.Length);

    /// <summary>
    ///  Try Read Leg Pay Frequencey
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
    ///  Encode Leg Pay Frequencey
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(string value)
    {
        var length = value.Length;
        Bytes[0] = length > 0 ? (byte)value[0] : (byte)0;
        Bytes[1] = length > 1 ? (byte)value[1] : (byte)0;
        Bytes[2] = length > 2 ? (byte)value[2] : (byte)0;
    }

    /// <summary>
    ///  Leg Pay Frequencey as string
    /// </summary>
    public readonly override string ToString()
        => Value;

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal fixed byte Bytes[Size];
}

using System.Runtime.CompilerServices;

namespace Cme.Streamlined;

/// <summary>
///  Leg Currency: Currency associated with a particular Leg's quantity
/// </summary>

public unsafe struct LegCurrency
{
    /// <summary>
    ///  Fix Tag for Leg Currency
    /// </summary>
    public const ushort FixTag = 556;

    /// <summary>
    ///  Size of Leg Currency underlying field in bytes
    /// </summary>
    public const int Size = 3;

    /// <summary>
    ///  Length of Leg Currency field
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
    ///  Leg Currency value
    /// </summary>
    public readonly string Value
        => Decode(this);

    /// <summary>
    ///  Does Leg Currency field contain a value?
    /// </summary>
    public bool HasValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Bytes[0] != 0; }
    }

    /// <summary>
    ///  Read Leg Currency
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Decode(LegCurrency value)
        => new string((sbyte*)value.Bytes, 0, value.Length);

    /// <summary>
    ///  Try Read Leg Currency
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
    ///  Encode Leg Currency
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
    ///  Leg Currency as string
    /// </summary>
    public readonly override string ToString()
        => Value;

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal fixed byte Bytes[Size];
}

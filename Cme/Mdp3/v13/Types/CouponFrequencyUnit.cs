using System.Runtime.CompilerServices;

namespace Cme.Mdp3;

/// <summary>
///  Coupon Frequency Unit: Time unit associated with the frequency of the bond's coupon payment
/// </summary>

public unsafe struct CouponFrequencyUnit
{
    /// <summary>
    ///  Fix Tag for Coupon Frequency Unit
    /// </summary>
    public const ushort FixTag = 1949;

    /// <summary>
    ///  Size of Coupon Frequency Unit underlying field in bytes
    /// </summary>
    public const int Size = 3;

    /// <summary>
    ///  Length of Coupon Frequency Unit field
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
    ///  Coupon Frequency Unit value
    /// </summary>
    public readonly string Value
        => Decode(this);

    /// <summary>
    ///  Does Coupon Frequency Unit field contain a value?
    /// </summary>
    public bool HasValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Bytes[0] != 0; }
    }

    /// <summary>
    ///  Read Coupon Frequency Unit
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Decode(CouponFrequencyUnit value)
        => new string((sbyte*)value.Bytes, 0, value.Length);

    /// <summary>
    ///  Try Read Coupon Frequency Unit
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
    ///  Encode Coupon Frequency Unit
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
    ///  Coupon Frequency Unit as string
    /// </summary>
    public readonly override string ToString()
        => Value;

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal fixed byte Bytes[Size];
}

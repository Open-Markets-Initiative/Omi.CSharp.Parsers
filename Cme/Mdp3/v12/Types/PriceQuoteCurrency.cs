using System.Runtime.CompilerServices;

namespace Cme.Mdp3;

/// <summary>
///  Price Quote Currency: Local (counter) currency
/// </summary>

public unsafe struct PriceQuoteCurrency
{
    /// <summary>
    ///  Fix Tag for Price Quote Currency
    /// </summary>
    public const ushort FixTag = 1524;

    /// <summary>
    ///  Size of Price Quote Currency underlying field in bytes
    /// </summary>
    public const int Size = 3;

    /// <summary>
    ///  Length of Price Quote Currency field
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
    ///  Price Quote Currency value
    /// </summary>
    public readonly string Value
        => Decode(this);

    /// <summary>
    ///  Does Price Quote Currency field contain a value?
    /// </summary>
    public bool HasValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Bytes[0] != 0; }
    }

    /// <summary>
    ///  Read Price Quote Currency
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Decode(PriceQuoteCurrency value)
        => new string((sbyte*)value.Bytes, 0, value.Length);

    /// <summary>
    ///  Try Read Price Quote Currency
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
    ///  Encode Price Quote Currency
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
    ///  Price Quote Currency as string
    /// </summary>
    public readonly override string ToString()
        => Value;

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal fixed byte Bytes[Size];
}

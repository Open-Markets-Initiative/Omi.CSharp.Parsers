using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Security Symbol: Denotes the security symbol.
/// </summary>

public unsafe struct SecuritySymbol
{
    /// <summary>
    ///  Size of Security Symbol underlying field in bytes
    /// </summary>
    public const int Size = 6;

    /// <summary>
    ///  Length of Security Symbol field
    /// </summary>
    public int Length
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (Bytes[0] == (byte)' ') { return 0; }
            if (Bytes[1] == (byte)' ') { return 1; }
            if (Bytes[2] == (byte)' ') { return 2; }
            if (Bytes[3] == (byte)' ') { return 3; }
            if (Bytes[4] == (byte)' ') { return 4; }
            if (Bytes[5] == (byte)' ') { return 5; }

            return 6;
        }
    }

    /// <summary>
    ///  Security Symbol value
    /// </summary>
    public readonly string Value
        => Decode(this);

    /// <summary>
    ///  Does Security Symbol field contain a value?
    /// </summary>
    public bool HasValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Bytes[0] != (byte)' '; }
    }

    /// <summary>
    ///  Read Security Symbol
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Decode(SecuritySymbol value)
        => new string((sbyte*)value.Bytes, 0, value.Length);

    /// <summary>
    ///  Try Read Security Symbol
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
    ///  Encode Security Symbol
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(string value)
    {
        var length = value.Length;
        Bytes[0] = length > 0 ? (byte)value[0] : (byte)' ';
        Bytes[1] = length > 1 ? (byte)value[1] : (byte)' ';
        Bytes[2] = length > 2 ? (byte)value[2] : (byte)' ';
        Bytes[3] = length > 3 ? (byte)value[3] : (byte)' ';
        Bytes[4] = length > 4 ? (byte)value[4] : (byte)' ';
        Bytes[5] = length > 5 ? (byte)value[5] : (byte)' ';
    }

    /// <summary>
    ///  Security Symbol as string
    /// </summary>
    public readonly override string ToString()
        => Value;

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal fixed byte Bytes[Size];
}

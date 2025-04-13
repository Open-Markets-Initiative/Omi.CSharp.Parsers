using System.Runtime.CompilerServices;

namespace Iex.Tops;

/// <summary>
///  Reason: Reason for the trading status change
/// </summary>

public unsafe struct Reason
{
    /// <summary>
    ///  Size of Reason underlying field in bytes
    /// </summary>
    public const int Size = 4;

    /// <summary>
    ///  Length of Reason field
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

            return 4;
        }
    }

    /// <summary>
    ///  Reason value
    /// </summary>
    public readonly string Value
        => Decode(this);

    /// <summary>
    ///  Does Reason field contain a value?
    /// </summary>
    public bool HasValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Bytes[0] != (byte)' '; }
    }

    /// <summary>
    ///  Read Reason
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Decode(Reason value)
        => new string((sbyte*)value.Bytes, 0, value.Length);

    /// <summary>
    ///  Try Read Reason
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
    ///  Encode Reason
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Encode(string value)
    {
        var length = value.Length;
        Bytes[0] = length > 0 ? (byte)value[0] : (byte)' ';
        Bytes[1] = length > 1 ? (byte)value[1] : (byte)' ';
        Bytes[2] = length > 2 ? (byte)value[2] : (byte)' ';
        Bytes[3] = length > 3 ? (byte)value[3] : (byte)' ';
    }

    /// <summary>
    ///  Reason as string
    /// </summary>
    public readonly override string ToString()
        => Value;

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal fixed byte Bytes[Size];
}

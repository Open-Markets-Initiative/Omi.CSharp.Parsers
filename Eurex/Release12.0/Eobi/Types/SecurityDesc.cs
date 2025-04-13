using System.Runtime.CompilerServices;

namespace Eurex.Eobi;

/// <summary>
///  Security Desc
/// </summary>
public unsafe struct SecurityDesc
{
    /// <summary>
    ///  Fix Tag for Security Desc
    /// </summary>
    public const ushort FixTag = 107;

    /// <summary>
    ///  Size of Security Desc underlying field in bytes
    /// </summary>
    public const int Size = 40;

    /// <summary>
    ///  Length of Security Desc field
    /// </summary>
    public int Length
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (Bytes[0] == 0) { return 0; }
            if (Bytes[1] == (byte)' ') { return 1; }
            if (Bytes[2] == (byte)' ') { return 2; }
            if (Bytes[3] == (byte)' ') { return 3; }
            if (Bytes[4] == (byte)' ') { return 4; }
            if (Bytes[5] == (byte)' ') { return 5; }
            if (Bytes[6] == (byte)' ') { return 6; }
            if (Bytes[7] == (byte)' ') { return 7; }
            if (Bytes[8] == (byte)' ') { return 8; }
            if (Bytes[9] == (byte)' ') { return 9; }
            if (Bytes[10] == (byte)' ') { return 10; }
            if (Bytes[11] == (byte)' ') { return 11; }
            if (Bytes[12] == (byte)' ') { return 12; }
            if (Bytes[13] == (byte)' ') { return 13; }
            if (Bytes[14] == (byte)' ') { return 14; }
            if (Bytes[15] == (byte)' ') { return 15; }
            if (Bytes[16] == (byte)' ') { return 16; }
            if (Bytes[17] == (byte)' ') { return 17; }
            if (Bytes[18] == (byte)' ') { return 18; }
            if (Bytes[19] == (byte)' ') { return 19; }
            if (Bytes[20] == (byte)' ') { return 20; }
            if (Bytes[21] == (byte)' ') { return 21; }
            if (Bytes[22] == (byte)' ') { return 22; }
            if (Bytes[23] == (byte)' ') { return 23; }
            if (Bytes[24] == (byte)' ') { return 24; }
            if (Bytes[25] == (byte)' ') { return 25; }
            if (Bytes[26] == (byte)' ') { return 26; }
            if (Bytes[27] == (byte)' ') { return 27; }
            if (Bytes[28] == (byte)' ') { return 28; }
            if (Bytes[29] == (byte)' ') { return 29; }
            if (Bytes[30] == (byte)' ') { return 30; }
            if (Bytes[31] == (byte)' ') { return 31; }
            if (Bytes[32] == (byte)' ') { return 32; }
            if (Bytes[33] == (byte)' ') { return 33; }
            if (Bytes[34] == (byte)' ') { return 34; }
            if (Bytes[35] == (byte)' ') { return 35; }
            if (Bytes[36] == (byte)' ') { return 36; }
            if (Bytes[37] == (byte)' ') { return 37; }
            if (Bytes[38] == (byte)' ') { return 38; }
            if (Bytes[39] == (byte)' ') { return 39; }

            return 40;
        }
    }

    /// <summary>
    ///  Security Desc value
    /// </summary>
    public readonly string Value
        => Decode(this);

    /// <summary>
    ///  Does Security Desc field contain a value?
    /// </summary>
    public bool HasValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Bytes[0] != 0; }
    }

    /// <summary>
    ///  Read Security Desc
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Decode(SecurityDesc value)
        => new string((sbyte*)value.Bytes, 0, value.Length);

    /// <summary>
    ///  Try Read Security Desc
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
    ///  Encode Security Desc
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
        Bytes[6] = length > 6 ? (byte)value[6] : (byte)' ';
        Bytes[7] = length > 7 ? (byte)value[7] : (byte)' ';
        Bytes[8] = length > 8 ? (byte)value[8] : (byte)' ';
        Bytes[9] = length > 9 ? (byte)value[9] : (byte)' ';
        Bytes[10] = length > 10 ? (byte)value[10] : (byte)' ';
        Bytes[11] = length > 11 ? (byte)value[11] : (byte)' ';
        Bytes[12] = length > 12 ? (byte)value[12] : (byte)' ';
        Bytes[13] = length > 13 ? (byte)value[13] : (byte)' ';
        Bytes[14] = length > 14 ? (byte)value[14] : (byte)' ';
        Bytes[15] = length > 15 ? (byte)value[15] : (byte)' ';
        Bytes[16] = length > 16 ? (byte)value[16] : (byte)' ';
        Bytes[17] = length > 17 ? (byte)value[17] : (byte)' ';
        Bytes[18] = length > 18 ? (byte)value[18] : (byte)' ';
        Bytes[19] = length > 19 ? (byte)value[19] : (byte)' ';
        Bytes[20] = length > 20 ? (byte)value[20] : (byte)' ';
        Bytes[21] = length > 21 ? (byte)value[21] : (byte)' ';
        Bytes[22] = length > 22 ? (byte)value[22] : (byte)' ';
        Bytes[23] = length > 23 ? (byte)value[23] : (byte)' ';
        Bytes[24] = length > 24 ? (byte)value[24] : (byte)' ';
        Bytes[25] = length > 25 ? (byte)value[25] : (byte)' ';
        Bytes[26] = length > 26 ? (byte)value[26] : (byte)' ';
        Bytes[27] = length > 27 ? (byte)value[27] : (byte)' ';
        Bytes[28] = length > 28 ? (byte)value[28] : (byte)' ';
        Bytes[29] = length > 29 ? (byte)value[29] : (byte)' ';
        Bytes[30] = length > 30 ? (byte)value[30] : (byte)' ';
        Bytes[31] = length > 31 ? (byte)value[31] : (byte)' ';
        Bytes[32] = length > 32 ? (byte)value[32] : (byte)' ';
        Bytes[33] = length > 33 ? (byte)value[33] : (byte)' ';
        Bytes[34] = length > 34 ? (byte)value[34] : (byte)' ';
        Bytes[35] = length > 35 ? (byte)value[35] : (byte)' ';
        Bytes[36] = length > 36 ? (byte)value[36] : (byte)' ';
        Bytes[37] = length > 37 ? (byte)value[37] : (byte)' ';
        Bytes[38] = length > 38 ? (byte)value[38] : (byte)' ';
        Bytes[39] = length > 39 ? (byte)value[39] : (byte)' ';
    }

    /// <summary>
    ///  Security Desc as string
    /// </summary>
    public readonly override string ToString()
        => Value;

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal fixed byte Bytes[Size];
}

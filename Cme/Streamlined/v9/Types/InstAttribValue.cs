using System.Runtime.CompilerServices;

namespace Cme.Streamlined;

/// <summary>
///  Inst Attrib Value: Attribute value appropriate to the InstrAttribType (871) field.
/// </summary>

public unsafe struct InstAttribValue
{
    /// <summary>
    ///  Fix Tag for Inst Attrib Value
    /// </summary>
    public const ushort FixTag = 872;

    /// <summary>
    ///  Size of Inst Attrib Value underlying field in bytes
    /// </summary>
    public const int Size = 100;

    /// <summary>
    ///  Length of Inst Attrib Value field
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
            if (Bytes[5] == 0) { return 5; }
            if (Bytes[6] == 0) { return 6; }
            if (Bytes[7] == 0) { return 7; }
            if (Bytes[8] == 0) { return 8; }
            if (Bytes[9] == 0) { return 9; }
            if (Bytes[10] == 0) { return 10; }
            if (Bytes[11] == 0) { return 11; }
            if (Bytes[12] == 0) { return 12; }
            if (Bytes[13] == 0) { return 13; }
            if (Bytes[14] == 0) { return 14; }
            if (Bytes[15] == 0) { return 15; }
            if (Bytes[16] == 0) { return 16; }
            if (Bytes[17] == 0) { return 17; }
            if (Bytes[18] == 0) { return 18; }
            if (Bytes[19] == 0) { return 19; }
            if (Bytes[20] == 0) { return 20; }
            if (Bytes[21] == 0) { return 21; }
            if (Bytes[22] == 0) { return 22; }
            if (Bytes[23] == 0) { return 23; }
            if (Bytes[24] == 0) { return 24; }
            if (Bytes[25] == 0) { return 25; }
            if (Bytes[26] == 0) { return 26; }
            if (Bytes[27] == 0) { return 27; }
            if (Bytes[28] == 0) { return 28; }
            if (Bytes[29] == 0) { return 29; }
            if (Bytes[30] == 0) { return 30; }
            if (Bytes[31] == 0) { return 31; }
            if (Bytes[32] == 0) { return 32; }
            if (Bytes[33] == 0) { return 33; }
            if (Bytes[34] == 0) { return 34; }
            if (Bytes[35] == 0) { return 35; }
            if (Bytes[36] == 0) { return 36; }
            if (Bytes[37] == 0) { return 37; }
            if (Bytes[38] == 0) { return 38; }
            if (Bytes[39] == 0) { return 39; }
            if (Bytes[40] == 0) { return 40; }
            if (Bytes[41] == 0) { return 41; }
            if (Bytes[42] == 0) { return 42; }
            if (Bytes[43] == 0) { return 43; }
            if (Bytes[44] == 0) { return 44; }
            if (Bytes[45] == 0) { return 45; }
            if (Bytes[46] == 0) { return 46; }
            if (Bytes[47] == 0) { return 47; }
            if (Bytes[48] == 0) { return 48; }
            if (Bytes[49] == 0) { return 49; }
            if (Bytes[50] == 0) { return 50; }
            if (Bytes[51] == 0) { return 51; }
            if (Bytes[52] == 0) { return 52; }
            if (Bytes[53] == 0) { return 53; }
            if (Bytes[54] == 0) { return 54; }
            if (Bytes[55] == 0) { return 55; }
            if (Bytes[56] == 0) { return 56; }
            if (Bytes[57] == 0) { return 57; }
            if (Bytes[58] == 0) { return 58; }
            if (Bytes[59] == 0) { return 59; }
            if (Bytes[60] == 0) { return 60; }
            if (Bytes[61] == 0) { return 61; }
            if (Bytes[62] == 0) { return 62; }
            if (Bytes[63] == 0) { return 63; }
            if (Bytes[64] == 0) { return 64; }
            if (Bytes[65] == 0) { return 65; }
            if (Bytes[66] == 0) { return 66; }
            if (Bytes[67] == 0) { return 67; }
            if (Bytes[68] == 0) { return 68; }
            if (Bytes[69] == 0) { return 69; }
            if (Bytes[70] == 0) { return 70; }
            if (Bytes[71] == 0) { return 71; }
            if (Bytes[72] == 0) { return 72; }
            if (Bytes[73] == 0) { return 73; }
            if (Bytes[74] == 0) { return 74; }
            if (Bytes[75] == 0) { return 75; }
            if (Bytes[76] == 0) { return 76; }
            if (Bytes[77] == 0) { return 77; }
            if (Bytes[78] == 0) { return 78; }
            if (Bytes[79] == 0) { return 79; }
            if (Bytes[80] == 0) { return 80; }
            if (Bytes[81] == 0) { return 81; }
            if (Bytes[82] == 0) { return 82; }
            if (Bytes[83] == 0) { return 83; }
            if (Bytes[84] == 0) { return 84; }
            if (Bytes[85] == 0) { return 85; }
            if (Bytes[86] == 0) { return 86; }
            if (Bytes[87] == 0) { return 87; }
            if (Bytes[88] == 0) { return 88; }
            if (Bytes[89] == 0) { return 89; }
            if (Bytes[90] == 0) { return 90; }
            if (Bytes[91] == 0) { return 91; }
            if (Bytes[92] == 0) { return 92; }
            if (Bytes[93] == 0) { return 93; }
            if (Bytes[94] == 0) { return 94; }
            if (Bytes[95] == 0) { return 95; }
            if (Bytes[96] == 0) { return 96; }
            if (Bytes[97] == 0) { return 97; }
            if (Bytes[98] == 0) { return 98; }
            if (Bytes[99] == 0) { return 99; }

            return 100;
        }
    }

    /// <summary>
    ///  Inst Attrib Value value
    /// </summary>
    public readonly string Value
        => Decode(this);

    /// <summary>
    ///  Does Inst Attrib Value field contain a value?
    /// </summary>
    public bool HasValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Bytes[0] != 0; }
    }

    /// <summary>
    ///  Read Inst Attrib Value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Decode(InstAttribValue value)
        => new string((sbyte*)value.Bytes, 0, value.Length);

    /// <summary>
    ///  Try Read Inst Attrib Value
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
    ///  Encode Inst Attrib Value
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
        Bytes[5] = length > 5 ? (byte)value[5] : (byte)0;
        Bytes[6] = length > 6 ? (byte)value[6] : (byte)0;
        Bytes[7] = length > 7 ? (byte)value[7] : (byte)0;
        Bytes[8] = length > 8 ? (byte)value[8] : (byte)0;
        Bytes[9] = length > 9 ? (byte)value[9] : (byte)0;
        Bytes[10] = length > 10 ? (byte)value[10] : (byte)0;
        Bytes[11] = length > 11 ? (byte)value[11] : (byte)0;
        Bytes[12] = length > 12 ? (byte)value[12] : (byte)0;
        Bytes[13] = length > 13 ? (byte)value[13] : (byte)0;
        Bytes[14] = length > 14 ? (byte)value[14] : (byte)0;
        Bytes[15] = length > 15 ? (byte)value[15] : (byte)0;
        Bytes[16] = length > 16 ? (byte)value[16] : (byte)0;
        Bytes[17] = length > 17 ? (byte)value[17] : (byte)0;
        Bytes[18] = length > 18 ? (byte)value[18] : (byte)0;
        Bytes[19] = length > 19 ? (byte)value[19] : (byte)0;
        Bytes[20] = length > 20 ? (byte)value[20] : (byte)0;
        Bytes[21] = length > 21 ? (byte)value[21] : (byte)0;
        Bytes[22] = length > 22 ? (byte)value[22] : (byte)0;
        Bytes[23] = length > 23 ? (byte)value[23] : (byte)0;
        Bytes[24] = length > 24 ? (byte)value[24] : (byte)0;
        Bytes[25] = length > 25 ? (byte)value[25] : (byte)0;
        Bytes[26] = length > 26 ? (byte)value[26] : (byte)0;
        Bytes[27] = length > 27 ? (byte)value[27] : (byte)0;
        Bytes[28] = length > 28 ? (byte)value[28] : (byte)0;
        Bytes[29] = length > 29 ? (byte)value[29] : (byte)0;
        Bytes[30] = length > 30 ? (byte)value[30] : (byte)0;
        Bytes[31] = length > 31 ? (byte)value[31] : (byte)0;
        Bytes[32] = length > 32 ? (byte)value[32] : (byte)0;
        Bytes[33] = length > 33 ? (byte)value[33] : (byte)0;
        Bytes[34] = length > 34 ? (byte)value[34] : (byte)0;
        Bytes[35] = length > 35 ? (byte)value[35] : (byte)0;
        Bytes[36] = length > 36 ? (byte)value[36] : (byte)0;
        Bytes[37] = length > 37 ? (byte)value[37] : (byte)0;
        Bytes[38] = length > 38 ? (byte)value[38] : (byte)0;
        Bytes[39] = length > 39 ? (byte)value[39] : (byte)0;
        Bytes[40] = length > 40 ? (byte)value[40] : (byte)0;
        Bytes[41] = length > 41 ? (byte)value[41] : (byte)0;
        Bytes[42] = length > 42 ? (byte)value[42] : (byte)0;
        Bytes[43] = length > 43 ? (byte)value[43] : (byte)0;
        Bytes[44] = length > 44 ? (byte)value[44] : (byte)0;
        Bytes[45] = length > 45 ? (byte)value[45] : (byte)0;
        Bytes[46] = length > 46 ? (byte)value[46] : (byte)0;
        Bytes[47] = length > 47 ? (byte)value[47] : (byte)0;
        Bytes[48] = length > 48 ? (byte)value[48] : (byte)0;
        Bytes[49] = length > 49 ? (byte)value[49] : (byte)0;
        Bytes[50] = length > 50 ? (byte)value[50] : (byte)0;
        Bytes[51] = length > 51 ? (byte)value[51] : (byte)0;
        Bytes[52] = length > 52 ? (byte)value[52] : (byte)0;
        Bytes[53] = length > 53 ? (byte)value[53] : (byte)0;
        Bytes[54] = length > 54 ? (byte)value[54] : (byte)0;
        Bytes[55] = length > 55 ? (byte)value[55] : (byte)0;
        Bytes[56] = length > 56 ? (byte)value[56] : (byte)0;
        Bytes[57] = length > 57 ? (byte)value[57] : (byte)0;
        Bytes[58] = length > 58 ? (byte)value[58] : (byte)0;
        Bytes[59] = length > 59 ? (byte)value[59] : (byte)0;
        Bytes[60] = length > 60 ? (byte)value[60] : (byte)0;
        Bytes[61] = length > 61 ? (byte)value[61] : (byte)0;
        Bytes[62] = length > 62 ? (byte)value[62] : (byte)0;
        Bytes[63] = length > 63 ? (byte)value[63] : (byte)0;
        Bytes[64] = length > 64 ? (byte)value[64] : (byte)0;
        Bytes[65] = length > 65 ? (byte)value[65] : (byte)0;
        Bytes[66] = length > 66 ? (byte)value[66] : (byte)0;
        Bytes[67] = length > 67 ? (byte)value[67] : (byte)0;
        Bytes[68] = length > 68 ? (byte)value[68] : (byte)0;
        Bytes[69] = length > 69 ? (byte)value[69] : (byte)0;
        Bytes[70] = length > 70 ? (byte)value[70] : (byte)0;
        Bytes[71] = length > 71 ? (byte)value[71] : (byte)0;
        Bytes[72] = length > 72 ? (byte)value[72] : (byte)0;
        Bytes[73] = length > 73 ? (byte)value[73] : (byte)0;
        Bytes[74] = length > 74 ? (byte)value[74] : (byte)0;
        Bytes[75] = length > 75 ? (byte)value[75] : (byte)0;
        Bytes[76] = length > 76 ? (byte)value[76] : (byte)0;
        Bytes[77] = length > 77 ? (byte)value[77] : (byte)0;
        Bytes[78] = length > 78 ? (byte)value[78] : (byte)0;
        Bytes[79] = length > 79 ? (byte)value[79] : (byte)0;
        Bytes[80] = length > 80 ? (byte)value[80] : (byte)0;
        Bytes[81] = length > 81 ? (byte)value[81] : (byte)0;
        Bytes[82] = length > 82 ? (byte)value[82] : (byte)0;
        Bytes[83] = length > 83 ? (byte)value[83] : (byte)0;
        Bytes[84] = length > 84 ? (byte)value[84] : (byte)0;
        Bytes[85] = length > 85 ? (byte)value[85] : (byte)0;
        Bytes[86] = length > 86 ? (byte)value[86] : (byte)0;
        Bytes[87] = length > 87 ? (byte)value[87] : (byte)0;
        Bytes[88] = length > 88 ? (byte)value[88] : (byte)0;
        Bytes[89] = length > 89 ? (byte)value[89] : (byte)0;
        Bytes[90] = length > 90 ? (byte)value[90] : (byte)0;
        Bytes[91] = length > 91 ? (byte)value[91] : (byte)0;
        Bytes[92] = length > 92 ? (byte)value[92] : (byte)0;
        Bytes[93] = length > 93 ? (byte)value[93] : (byte)0;
        Bytes[94] = length > 94 ? (byte)value[94] : (byte)0;
        Bytes[95] = length > 95 ? (byte)value[95] : (byte)0;
        Bytes[96] = length > 96 ? (byte)value[96] : (byte)0;
        Bytes[97] = length > 97 ? (byte)value[97] : (byte)0;
        Bytes[98] = length > 98 ? (byte)value[98] : (byte)0;
        Bytes[99] = length > 99 ? (byte)value[99] : (byte)0;
    }

    /// <summary>
    ///  Inst Attrib Value as string
    /// </summary>
    public readonly override string ToString()
        => Value;

    /// <summary>
    ///  Underlying bytes
    /// </summary>
    internal fixed byte Bytes[Size];
}

using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Text: Free format text string. May include logout confirmation or reason for logout
    /// </summary>
    public unsafe struct Text
    {
        /// <summary>
        ///  Fix Tag for Text
        /// </summary>
        public const ushort FixTag = 58;

        /// <summary>
        ///  Size of Text underlying field in bytes
        /// </summary>
        public const int Size = 180;

        /// <summary>
        ///  Length of Text field
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
                if (Bytes[100] == 0) { return 100; }
                if (Bytes[101] == 0) { return 101; }
                if (Bytes[102] == 0) { return 102; }
                if (Bytes[103] == 0) { return 103; }
                if (Bytes[104] == 0) { return 104; }
                if (Bytes[105] == 0) { return 105; }
                if (Bytes[106] == 0) { return 106; }
                if (Bytes[107] == 0) { return 107; }
                if (Bytes[108] == 0) { return 108; }
                if (Bytes[109] == 0) { return 109; }
                if (Bytes[110] == 0) { return 110; }
                if (Bytes[111] == 0) { return 111; }
                if (Bytes[112] == 0) { return 112; }
                if (Bytes[113] == 0) { return 113; }
                if (Bytes[114] == 0) { return 114; }
                if (Bytes[115] == 0) { return 115; }
                if (Bytes[116] == 0) { return 116; }
                if (Bytes[117] == 0) { return 117; }
                if (Bytes[118] == 0) { return 118; }
                if (Bytes[119] == 0) { return 119; }
                if (Bytes[120] == 0) { return 120; }
                if (Bytes[121] == 0) { return 121; }
                if (Bytes[122] == 0) { return 122; }
                if (Bytes[123] == 0) { return 123; }
                if (Bytes[124] == 0) { return 124; }
                if (Bytes[125] == 0) { return 125; }
                if (Bytes[126] == 0) { return 126; }
                if (Bytes[127] == 0) { return 127; }
                if (Bytes[128] == 0) { return 128; }
                if (Bytes[129] == 0) { return 129; }
                if (Bytes[130] == 0) { return 130; }
                if (Bytes[131] == 0) { return 131; }
                if (Bytes[132] == 0) { return 132; }
                if (Bytes[133] == 0) { return 133; }
                if (Bytes[134] == 0) { return 134; }
                if (Bytes[135] == 0) { return 135; }
                if (Bytes[136] == 0) { return 136; }
                if (Bytes[137] == 0) { return 137; }
                if (Bytes[138] == 0) { return 138; }
                if (Bytes[139] == 0) { return 139; }
                if (Bytes[140] == 0) { return 140; }
                if (Bytes[141] == 0) { return 141; }
                if (Bytes[142] == 0) { return 142; }
                if (Bytes[143] == 0) { return 143; }
                if (Bytes[144] == 0) { return 144; }
                if (Bytes[145] == 0) { return 145; }
                if (Bytes[146] == 0) { return 146; }
                if (Bytes[147] == 0) { return 147; }
                if (Bytes[148] == 0) { return 148; }
                if (Bytes[149] == 0) { return 149; }
                if (Bytes[150] == 0) { return 150; }
                if (Bytes[151] == 0) { return 151; }
                if (Bytes[152] == 0) { return 152; }
                if (Bytes[153] == 0) { return 153; }
                if (Bytes[154] == 0) { return 154; }
                if (Bytes[155] == 0) { return 155; }
                if (Bytes[156] == 0) { return 156; }
                if (Bytes[157] == 0) { return 157; }
                if (Bytes[158] == 0) { return 158; }
                if (Bytes[159] == 0) { return 159; }
                if (Bytes[160] == 0) { return 160; }
                if (Bytes[161] == 0) { return 161; }
                if (Bytes[162] == 0) { return 162; }
                if (Bytes[163] == 0) { return 163; }
                if (Bytes[164] == 0) { return 164; }
                if (Bytes[165] == 0) { return 165; }
                if (Bytes[166] == 0) { return 166; }
                if (Bytes[167] == 0) { return 167; }
                if (Bytes[168] == 0) { return 168; }
                if (Bytes[169] == 0) { return 169; }
                if (Bytes[170] == 0) { return 170; }
                if (Bytes[171] == 0) { return 171; }
                if (Bytes[172] == 0) { return 172; }
                if (Bytes[173] == 0) { return 173; }
                if (Bytes[174] == 0) { return 174; }
                if (Bytes[175] == 0) { return 175; }
                if (Bytes[176] == 0) { return 176; }
                if (Bytes[177] == 0) { return 177; }
                if (Bytes[178] == 0) { return 178; }
                if (Bytes[179] == 0) { return 179; }

                return 180;
            }
        }

        /// <summary>
        ///  Text value
        /// </summary>
        public readonly string Value
            => Decode(this);

        /// <summary>
        ///  Does Text field contain a value?
        /// </summary>
        public bool HasValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return Bytes[0] != 0; }
        }

        /// <summary>
        ///  Read Text
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Decode(Text value)
            => new string((sbyte*)value.Bytes, 0, value.Length);

        /// <summary>
        ///  Try Read Text
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
        ///  Encode Text
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
            Bytes[100] = length > 100 ? (byte)value[100] : (byte)0;
            Bytes[101] = length > 101 ? (byte)value[101] : (byte)0;
            Bytes[102] = length > 102 ? (byte)value[102] : (byte)0;
            Bytes[103] = length > 103 ? (byte)value[103] : (byte)0;
            Bytes[104] = length > 104 ? (byte)value[104] : (byte)0;
            Bytes[105] = length > 105 ? (byte)value[105] : (byte)0;
            Bytes[106] = length > 106 ? (byte)value[106] : (byte)0;
            Bytes[107] = length > 107 ? (byte)value[107] : (byte)0;
            Bytes[108] = length > 108 ? (byte)value[108] : (byte)0;
            Bytes[109] = length > 109 ? (byte)value[109] : (byte)0;
            Bytes[110] = length > 110 ? (byte)value[110] : (byte)0;
            Bytes[111] = length > 111 ? (byte)value[111] : (byte)0;
            Bytes[112] = length > 112 ? (byte)value[112] : (byte)0;
            Bytes[113] = length > 113 ? (byte)value[113] : (byte)0;
            Bytes[114] = length > 114 ? (byte)value[114] : (byte)0;
            Bytes[115] = length > 115 ? (byte)value[115] : (byte)0;
            Bytes[116] = length > 116 ? (byte)value[116] : (byte)0;
            Bytes[117] = length > 117 ? (byte)value[117] : (byte)0;
            Bytes[118] = length > 118 ? (byte)value[118] : (byte)0;
            Bytes[119] = length > 119 ? (byte)value[119] : (byte)0;
            Bytes[120] = length > 120 ? (byte)value[120] : (byte)0;
            Bytes[121] = length > 121 ? (byte)value[121] : (byte)0;
            Bytes[122] = length > 122 ? (byte)value[122] : (byte)0;
            Bytes[123] = length > 123 ? (byte)value[123] : (byte)0;
            Bytes[124] = length > 124 ? (byte)value[124] : (byte)0;
            Bytes[125] = length > 125 ? (byte)value[125] : (byte)0;
            Bytes[126] = length > 126 ? (byte)value[126] : (byte)0;
            Bytes[127] = length > 127 ? (byte)value[127] : (byte)0;
            Bytes[128] = length > 128 ? (byte)value[128] : (byte)0;
            Bytes[129] = length > 129 ? (byte)value[129] : (byte)0;
            Bytes[130] = length > 130 ? (byte)value[130] : (byte)0;
            Bytes[131] = length > 131 ? (byte)value[131] : (byte)0;
            Bytes[132] = length > 132 ? (byte)value[132] : (byte)0;
            Bytes[133] = length > 133 ? (byte)value[133] : (byte)0;
            Bytes[134] = length > 134 ? (byte)value[134] : (byte)0;
            Bytes[135] = length > 135 ? (byte)value[135] : (byte)0;
            Bytes[136] = length > 136 ? (byte)value[136] : (byte)0;
            Bytes[137] = length > 137 ? (byte)value[137] : (byte)0;
            Bytes[138] = length > 138 ? (byte)value[138] : (byte)0;
            Bytes[139] = length > 139 ? (byte)value[139] : (byte)0;
            Bytes[140] = length > 140 ? (byte)value[140] : (byte)0;
            Bytes[141] = length > 141 ? (byte)value[141] : (byte)0;
            Bytes[142] = length > 142 ? (byte)value[142] : (byte)0;
            Bytes[143] = length > 143 ? (byte)value[143] : (byte)0;
            Bytes[144] = length > 144 ? (byte)value[144] : (byte)0;
            Bytes[145] = length > 145 ? (byte)value[145] : (byte)0;
            Bytes[146] = length > 146 ? (byte)value[146] : (byte)0;
            Bytes[147] = length > 147 ? (byte)value[147] : (byte)0;
            Bytes[148] = length > 148 ? (byte)value[148] : (byte)0;
            Bytes[149] = length > 149 ? (byte)value[149] : (byte)0;
            Bytes[150] = length > 150 ? (byte)value[150] : (byte)0;
            Bytes[151] = length > 151 ? (byte)value[151] : (byte)0;
            Bytes[152] = length > 152 ? (byte)value[152] : (byte)0;
            Bytes[153] = length > 153 ? (byte)value[153] : (byte)0;
            Bytes[154] = length > 154 ? (byte)value[154] : (byte)0;
            Bytes[155] = length > 155 ? (byte)value[155] : (byte)0;
            Bytes[156] = length > 156 ? (byte)value[156] : (byte)0;
            Bytes[157] = length > 157 ? (byte)value[157] : (byte)0;
            Bytes[158] = length > 158 ? (byte)value[158] : (byte)0;
            Bytes[159] = length > 159 ? (byte)value[159] : (byte)0;
            Bytes[160] = length > 160 ? (byte)value[160] : (byte)0;
            Bytes[161] = length > 161 ? (byte)value[161] : (byte)0;
            Bytes[162] = length > 162 ? (byte)value[162] : (byte)0;
            Bytes[163] = length > 163 ? (byte)value[163] : (byte)0;
            Bytes[164] = length > 164 ? (byte)value[164] : (byte)0;
            Bytes[165] = length > 165 ? (byte)value[165] : (byte)0;
            Bytes[166] = length > 166 ? (byte)value[166] : (byte)0;
            Bytes[167] = length > 167 ? (byte)value[167] : (byte)0;
            Bytes[168] = length > 168 ? (byte)value[168] : (byte)0;
            Bytes[169] = length > 169 ? (byte)value[169] : (byte)0;
            Bytes[170] = length > 170 ? (byte)value[170] : (byte)0;
            Bytes[171] = length > 171 ? (byte)value[171] : (byte)0;
            Bytes[172] = length > 172 ? (byte)value[172] : (byte)0;
            Bytes[173] = length > 173 ? (byte)value[173] : (byte)0;
            Bytes[174] = length > 174 ? (byte)value[174] : (byte)0;
            Bytes[175] = length > 175 ? (byte)value[175] : (byte)0;
            Bytes[176] = length > 176 ? (byte)value[176] : (byte)0;
            Bytes[177] = length > 177 ? (byte)value[177] : (byte)0;
            Bytes[178] = length > 178 ? (byte)value[178] : (byte)0;
            Bytes[179] = length > 179 ? (byte)value[179] : (byte)0;
        }

        /// <summary>
        ///  Text as string
        /// </summary>
        public readonly override string ToString()
            => Value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal fixed byte Bytes[Size];
    }
}
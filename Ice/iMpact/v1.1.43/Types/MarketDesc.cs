using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Market Desc: Description of the market
    /// </summary>
    public unsafe struct MarketDesc
    {
        /// <summary>
        ///  Size of Market Desc underlying field in bytes
        /// </summary>
        public const int Size = 120;

        /// <summary>
        ///  Length of Market Desc field
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

                return 120;
            }
        }

        /// <summary>
        ///  Does Market Desc field contain a value?
        /// </summary>
        public bool HasValue
            => Bytes[0] != 0;

        /// <summary>
        ///  Read Market Desc from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Length); }
        }

        /// <summary>
        ///  Try Read Market Desc
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out string value)
        {
            value = Decode();
            return HasValue;
        }

        /// <summary>
        ///  Encode Market Desc
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(string value)
        {
            var end = Math.Min(value.Length, Size);

            for (var i = 0; i < end; i++)
            {
                Bytes[i] = (byte)value[i];
            }

            for (var i = end; i < Size; i++)
            {
                Bytes[i] = 0;
            }
        }

        /// <summary>
        ///  Market Desc as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
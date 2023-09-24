using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Text 500: This general purpose text field could contain any post-trade instructions used by customers based on mutual understanding with their clearing firm. If incoming value is greater than max length then take the right most fifty bytes. No validation is done for valid values and this is a pass through to clearing. After any right justification if applicable the incoming value is flipped back in the execution report and also becomes an attribute of the order.
    /// </summary>
    public unsafe struct Text500
    {
        /// <summary>
        ///  Fix Tag for Text 500
        /// </summary>
        public const ushort FixTag = 58;

        /// <summary>
        ///  Size of Text 500 underlying field in bytes
        /// </summary>
        public const int Size = 500;

        /// <summary>
        ///  Length of Text 500 field
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
                if (Bytes[180] == 0) { return 180; }
                if (Bytes[181] == 0) { return 181; }
                if (Bytes[182] == 0) { return 182; }
                if (Bytes[183] == 0) { return 183; }
                if (Bytes[184] == 0) { return 184; }
                if (Bytes[185] == 0) { return 185; }
                if (Bytes[186] == 0) { return 186; }
                if (Bytes[187] == 0) { return 187; }
                if (Bytes[188] == 0) { return 188; }
                if (Bytes[189] == 0) { return 189; }
                if (Bytes[190] == 0) { return 190; }
                if (Bytes[191] == 0) { return 191; }
                if (Bytes[192] == 0) { return 192; }
                if (Bytes[193] == 0) { return 193; }
                if (Bytes[194] == 0) { return 194; }
                if (Bytes[195] == 0) { return 195; }
                if (Bytes[196] == 0) { return 196; }
                if (Bytes[197] == 0) { return 197; }
                if (Bytes[198] == 0) { return 198; }
                if (Bytes[199] == 0) { return 199; }
                if (Bytes[200] == 0) { return 200; }
                if (Bytes[201] == 0) { return 201; }
                if (Bytes[202] == 0) { return 202; }
                if (Bytes[203] == 0) { return 203; }
                if (Bytes[204] == 0) { return 204; }
                if (Bytes[205] == 0) { return 205; }
                if (Bytes[206] == 0) { return 206; }
                if (Bytes[207] == 0) { return 207; }
                if (Bytes[208] == 0) { return 208; }
                if (Bytes[209] == 0) { return 209; }
                if (Bytes[210] == 0) { return 210; }
                if (Bytes[211] == 0) { return 211; }
                if (Bytes[212] == 0) { return 212; }
                if (Bytes[213] == 0) { return 213; }
                if (Bytes[214] == 0) { return 214; }
                if (Bytes[215] == 0) { return 215; }
                if (Bytes[216] == 0) { return 216; }
                if (Bytes[217] == 0) { return 217; }
                if (Bytes[218] == 0) { return 218; }
                if (Bytes[219] == 0) { return 219; }
                if (Bytes[220] == 0) { return 220; }
                if (Bytes[221] == 0) { return 221; }
                if (Bytes[222] == 0) { return 222; }
                if (Bytes[223] == 0) { return 223; }
                if (Bytes[224] == 0) { return 224; }
                if (Bytes[225] == 0) { return 225; }
                if (Bytes[226] == 0) { return 226; }
                if (Bytes[227] == 0) { return 227; }
                if (Bytes[228] == 0) { return 228; }
                if (Bytes[229] == 0) { return 229; }
                if (Bytes[230] == 0) { return 230; }
                if (Bytes[231] == 0) { return 231; }
                if (Bytes[232] == 0) { return 232; }
                if (Bytes[233] == 0) { return 233; }
                if (Bytes[234] == 0) { return 234; }
                if (Bytes[235] == 0) { return 235; }
                if (Bytes[236] == 0) { return 236; }
                if (Bytes[237] == 0) { return 237; }
                if (Bytes[238] == 0) { return 238; }
                if (Bytes[239] == 0) { return 239; }
                if (Bytes[240] == 0) { return 240; }
                if (Bytes[241] == 0) { return 241; }
                if (Bytes[242] == 0) { return 242; }
                if (Bytes[243] == 0) { return 243; }
                if (Bytes[244] == 0) { return 244; }
                if (Bytes[245] == 0) { return 245; }
                if (Bytes[246] == 0) { return 246; }
                if (Bytes[247] == 0) { return 247; }
                if (Bytes[248] == 0) { return 248; }
                if (Bytes[249] == 0) { return 249; }
                if (Bytes[250] == 0) { return 250; }
                if (Bytes[251] == 0) { return 251; }
                if (Bytes[252] == 0) { return 252; }
                if (Bytes[253] == 0) { return 253; }
                if (Bytes[254] == 0) { return 254; }
                if (Bytes[255] == 0) { return 255; }
                if (Bytes[256] == 0) { return 256; }
                if (Bytes[257] == 0) { return 257; }
                if (Bytes[258] == 0) { return 258; }
                if (Bytes[259] == 0) { return 259; }
                if (Bytes[260] == 0) { return 260; }
                if (Bytes[261] == 0) { return 261; }
                if (Bytes[262] == 0) { return 262; }
                if (Bytes[263] == 0) { return 263; }
                if (Bytes[264] == 0) { return 264; }
                if (Bytes[265] == 0) { return 265; }
                if (Bytes[266] == 0) { return 266; }
                if (Bytes[267] == 0) { return 267; }
                if (Bytes[268] == 0) { return 268; }
                if (Bytes[269] == 0) { return 269; }
                if (Bytes[270] == 0) { return 270; }
                if (Bytes[271] == 0) { return 271; }
                if (Bytes[272] == 0) { return 272; }
                if (Bytes[273] == 0) { return 273; }
                if (Bytes[274] == 0) { return 274; }
                if (Bytes[275] == 0) { return 275; }
                if (Bytes[276] == 0) { return 276; }
                if (Bytes[277] == 0) { return 277; }
                if (Bytes[278] == 0) { return 278; }
                if (Bytes[279] == 0) { return 279; }
                if (Bytes[280] == 0) { return 280; }
                if (Bytes[281] == 0) { return 281; }
                if (Bytes[282] == 0) { return 282; }
                if (Bytes[283] == 0) { return 283; }
                if (Bytes[284] == 0) { return 284; }
                if (Bytes[285] == 0) { return 285; }
                if (Bytes[286] == 0) { return 286; }
                if (Bytes[287] == 0) { return 287; }
                if (Bytes[288] == 0) { return 288; }
                if (Bytes[289] == 0) { return 289; }
                if (Bytes[290] == 0) { return 290; }
                if (Bytes[291] == 0) { return 291; }
                if (Bytes[292] == 0) { return 292; }
                if (Bytes[293] == 0) { return 293; }
                if (Bytes[294] == 0) { return 294; }
                if (Bytes[295] == 0) { return 295; }
                if (Bytes[296] == 0) { return 296; }
                if (Bytes[297] == 0) { return 297; }
                if (Bytes[298] == 0) { return 298; }
                if (Bytes[299] == 0) { return 299; }
                if (Bytes[300] == 0) { return 300; }
                if (Bytes[301] == 0) { return 301; }
                if (Bytes[302] == 0) { return 302; }
                if (Bytes[303] == 0) { return 303; }
                if (Bytes[304] == 0) { return 304; }
                if (Bytes[305] == 0) { return 305; }
                if (Bytes[306] == 0) { return 306; }
                if (Bytes[307] == 0) { return 307; }
                if (Bytes[308] == 0) { return 308; }
                if (Bytes[309] == 0) { return 309; }
                if (Bytes[310] == 0) { return 310; }
                if (Bytes[311] == 0) { return 311; }
                if (Bytes[312] == 0) { return 312; }
                if (Bytes[313] == 0) { return 313; }
                if (Bytes[314] == 0) { return 314; }
                if (Bytes[315] == 0) { return 315; }
                if (Bytes[316] == 0) { return 316; }
                if (Bytes[317] == 0) { return 317; }
                if (Bytes[318] == 0) { return 318; }
                if (Bytes[319] == 0) { return 319; }
                if (Bytes[320] == 0) { return 320; }
                if (Bytes[321] == 0) { return 321; }
                if (Bytes[322] == 0) { return 322; }
                if (Bytes[323] == 0) { return 323; }
                if (Bytes[324] == 0) { return 324; }
                if (Bytes[325] == 0) { return 325; }
                if (Bytes[326] == 0) { return 326; }
                if (Bytes[327] == 0) { return 327; }
                if (Bytes[328] == 0) { return 328; }
                if (Bytes[329] == 0) { return 329; }
                if (Bytes[330] == 0) { return 330; }
                if (Bytes[331] == 0) { return 331; }
                if (Bytes[332] == 0) { return 332; }
                if (Bytes[333] == 0) { return 333; }
                if (Bytes[334] == 0) { return 334; }
                if (Bytes[335] == 0) { return 335; }
                if (Bytes[336] == 0) { return 336; }
                if (Bytes[337] == 0) { return 337; }
                if (Bytes[338] == 0) { return 338; }
                if (Bytes[339] == 0) { return 339; }
                if (Bytes[340] == 0) { return 340; }
                if (Bytes[341] == 0) { return 341; }
                if (Bytes[342] == 0) { return 342; }
                if (Bytes[343] == 0) { return 343; }
                if (Bytes[344] == 0) { return 344; }
                if (Bytes[345] == 0) { return 345; }
                if (Bytes[346] == 0) { return 346; }
                if (Bytes[347] == 0) { return 347; }
                if (Bytes[348] == 0) { return 348; }
                if (Bytes[349] == 0) { return 349; }
                if (Bytes[350] == 0) { return 350; }
                if (Bytes[351] == 0) { return 351; }
                if (Bytes[352] == 0) { return 352; }
                if (Bytes[353] == 0) { return 353; }
                if (Bytes[354] == 0) { return 354; }
                if (Bytes[355] == 0) { return 355; }
                if (Bytes[356] == 0) { return 356; }
                if (Bytes[357] == 0) { return 357; }
                if (Bytes[358] == 0) { return 358; }
                if (Bytes[359] == 0) { return 359; }
                if (Bytes[360] == 0) { return 360; }
                if (Bytes[361] == 0) { return 361; }
                if (Bytes[362] == 0) { return 362; }
                if (Bytes[363] == 0) { return 363; }
                if (Bytes[364] == 0) { return 364; }
                if (Bytes[365] == 0) { return 365; }
                if (Bytes[366] == 0) { return 366; }
                if (Bytes[367] == 0) { return 367; }
                if (Bytes[368] == 0) { return 368; }
                if (Bytes[369] == 0) { return 369; }
                if (Bytes[370] == 0) { return 370; }
                if (Bytes[371] == 0) { return 371; }
                if (Bytes[372] == 0) { return 372; }
                if (Bytes[373] == 0) { return 373; }
                if (Bytes[374] == 0) { return 374; }
                if (Bytes[375] == 0) { return 375; }
                if (Bytes[376] == 0) { return 376; }
                if (Bytes[377] == 0) { return 377; }
                if (Bytes[378] == 0) { return 378; }
                if (Bytes[379] == 0) { return 379; }
                if (Bytes[380] == 0) { return 380; }
                if (Bytes[381] == 0) { return 381; }
                if (Bytes[382] == 0) { return 382; }
                if (Bytes[383] == 0) { return 383; }
                if (Bytes[384] == 0) { return 384; }
                if (Bytes[385] == 0) { return 385; }
                if (Bytes[386] == 0) { return 386; }
                if (Bytes[387] == 0) { return 387; }
                if (Bytes[388] == 0) { return 388; }
                if (Bytes[389] == 0) { return 389; }
                if (Bytes[390] == 0) { return 390; }
                if (Bytes[391] == 0) { return 391; }
                if (Bytes[392] == 0) { return 392; }
                if (Bytes[393] == 0) { return 393; }
                if (Bytes[394] == 0) { return 394; }
                if (Bytes[395] == 0) { return 395; }
                if (Bytes[396] == 0) { return 396; }
                if (Bytes[397] == 0) { return 397; }
                if (Bytes[398] == 0) { return 398; }
                if (Bytes[399] == 0) { return 399; }
                if (Bytes[400] == 0) { return 400; }
                if (Bytes[401] == 0) { return 401; }
                if (Bytes[402] == 0) { return 402; }
                if (Bytes[403] == 0) { return 403; }
                if (Bytes[404] == 0) { return 404; }
                if (Bytes[405] == 0) { return 405; }
                if (Bytes[406] == 0) { return 406; }
                if (Bytes[407] == 0) { return 407; }
                if (Bytes[408] == 0) { return 408; }
                if (Bytes[409] == 0) { return 409; }
                if (Bytes[410] == 0) { return 410; }
                if (Bytes[411] == 0) { return 411; }
                if (Bytes[412] == 0) { return 412; }
                if (Bytes[413] == 0) { return 413; }
                if (Bytes[414] == 0) { return 414; }
                if (Bytes[415] == 0) { return 415; }
                if (Bytes[416] == 0) { return 416; }
                if (Bytes[417] == 0) { return 417; }
                if (Bytes[418] == 0) { return 418; }
                if (Bytes[419] == 0) { return 419; }
                if (Bytes[420] == 0) { return 420; }
                if (Bytes[421] == 0) { return 421; }
                if (Bytes[422] == 0) { return 422; }
                if (Bytes[423] == 0) { return 423; }
                if (Bytes[424] == 0) { return 424; }
                if (Bytes[425] == 0) { return 425; }
                if (Bytes[426] == 0) { return 426; }
                if (Bytes[427] == 0) { return 427; }
                if (Bytes[428] == 0) { return 428; }
                if (Bytes[429] == 0) { return 429; }
                if (Bytes[430] == 0) { return 430; }
                if (Bytes[431] == 0) { return 431; }
                if (Bytes[432] == 0) { return 432; }
                if (Bytes[433] == 0) { return 433; }
                if (Bytes[434] == 0) { return 434; }
                if (Bytes[435] == 0) { return 435; }
                if (Bytes[436] == 0) { return 436; }
                if (Bytes[437] == 0) { return 437; }
                if (Bytes[438] == 0) { return 438; }
                if (Bytes[439] == 0) { return 439; }
                if (Bytes[440] == 0) { return 440; }
                if (Bytes[441] == 0) { return 441; }
                if (Bytes[442] == 0) { return 442; }
                if (Bytes[443] == 0) { return 443; }
                if (Bytes[444] == 0) { return 444; }
                if (Bytes[445] == 0) { return 445; }
                if (Bytes[446] == 0) { return 446; }
                if (Bytes[447] == 0) { return 447; }
                if (Bytes[448] == 0) { return 448; }
                if (Bytes[449] == 0) { return 449; }
                if (Bytes[450] == 0) { return 450; }
                if (Bytes[451] == 0) { return 451; }
                if (Bytes[452] == 0) { return 452; }
                if (Bytes[453] == 0) { return 453; }
                if (Bytes[454] == 0) { return 454; }
                if (Bytes[455] == 0) { return 455; }
                if (Bytes[456] == 0) { return 456; }
                if (Bytes[457] == 0) { return 457; }
                if (Bytes[458] == 0) { return 458; }
                if (Bytes[459] == 0) { return 459; }
                if (Bytes[460] == 0) { return 460; }
                if (Bytes[461] == 0) { return 461; }
                if (Bytes[462] == 0) { return 462; }
                if (Bytes[463] == 0) { return 463; }
                if (Bytes[464] == 0) { return 464; }
                if (Bytes[465] == 0) { return 465; }
                if (Bytes[466] == 0) { return 466; }
                if (Bytes[467] == 0) { return 467; }
                if (Bytes[468] == 0) { return 468; }
                if (Bytes[469] == 0) { return 469; }
                if (Bytes[470] == 0) { return 470; }
                if (Bytes[471] == 0) { return 471; }
                if (Bytes[472] == 0) { return 472; }
                if (Bytes[473] == 0) { return 473; }
                if (Bytes[474] == 0) { return 474; }
                if (Bytes[475] == 0) { return 475; }
                if (Bytes[476] == 0) { return 476; }
                if (Bytes[477] == 0) { return 477; }
                if (Bytes[478] == 0) { return 478; }
                if (Bytes[479] == 0) { return 479; }
                if (Bytes[480] == 0) { return 480; }
                if (Bytes[481] == 0) { return 481; }
                if (Bytes[482] == 0) { return 482; }
                if (Bytes[483] == 0) { return 483; }
                if (Bytes[484] == 0) { return 484; }
                if (Bytes[485] == 0) { return 485; }
                if (Bytes[486] == 0) { return 486; }
                if (Bytes[487] == 0) { return 487; }
                if (Bytes[488] == 0) { return 488; }
                if (Bytes[489] == 0) { return 489; }
                if (Bytes[490] == 0) { return 490; }
                if (Bytes[491] == 0) { return 491; }
                if (Bytes[492] == 0) { return 492; }
                if (Bytes[493] == 0) { return 493; }
                if (Bytes[494] == 0) { return 494; }
                if (Bytes[495] == 0) { return 495; }
                if (Bytes[496] == 0) { return 496; }
                if (Bytes[497] == 0) { return 497; }
                if (Bytes[498] == 0) { return 498; }
                if (Bytes[499] == 0) { return 499; }

                return 500;
            }
        }

        /// <summary>
        ///  Text 500 value
        /// </summary>
        public readonly string Value
            => Decode(this);

        /// <summary>
        ///  Does Text 500 field contain a value?
        /// </summary>
        public bool HasValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return Bytes[0] != 0; }
        }

        /// <summary>
        ///  Read Text 500
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Decode(Text500 value)
            => new string((sbyte*)value.Bytes, 0, value.Length);

        /// <summary>
        ///  Try Read Text 500
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
        ///  Encode Text 500
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
            Bytes[180] = length > 180 ? (byte)value[180] : (byte)0;
            Bytes[181] = length > 181 ? (byte)value[181] : (byte)0;
            Bytes[182] = length > 182 ? (byte)value[182] : (byte)0;
            Bytes[183] = length > 183 ? (byte)value[183] : (byte)0;
            Bytes[184] = length > 184 ? (byte)value[184] : (byte)0;
            Bytes[185] = length > 185 ? (byte)value[185] : (byte)0;
            Bytes[186] = length > 186 ? (byte)value[186] : (byte)0;
            Bytes[187] = length > 187 ? (byte)value[187] : (byte)0;
            Bytes[188] = length > 188 ? (byte)value[188] : (byte)0;
            Bytes[189] = length > 189 ? (byte)value[189] : (byte)0;
            Bytes[190] = length > 190 ? (byte)value[190] : (byte)0;
            Bytes[191] = length > 191 ? (byte)value[191] : (byte)0;
            Bytes[192] = length > 192 ? (byte)value[192] : (byte)0;
            Bytes[193] = length > 193 ? (byte)value[193] : (byte)0;
            Bytes[194] = length > 194 ? (byte)value[194] : (byte)0;
            Bytes[195] = length > 195 ? (byte)value[195] : (byte)0;
            Bytes[196] = length > 196 ? (byte)value[196] : (byte)0;
            Bytes[197] = length > 197 ? (byte)value[197] : (byte)0;
            Bytes[198] = length > 198 ? (byte)value[198] : (byte)0;
            Bytes[199] = length > 199 ? (byte)value[199] : (byte)0;
            Bytes[200] = length > 200 ? (byte)value[200] : (byte)0;
            Bytes[201] = length > 201 ? (byte)value[201] : (byte)0;
            Bytes[202] = length > 202 ? (byte)value[202] : (byte)0;
            Bytes[203] = length > 203 ? (byte)value[203] : (byte)0;
            Bytes[204] = length > 204 ? (byte)value[204] : (byte)0;
            Bytes[205] = length > 205 ? (byte)value[205] : (byte)0;
            Bytes[206] = length > 206 ? (byte)value[206] : (byte)0;
            Bytes[207] = length > 207 ? (byte)value[207] : (byte)0;
            Bytes[208] = length > 208 ? (byte)value[208] : (byte)0;
            Bytes[209] = length > 209 ? (byte)value[209] : (byte)0;
            Bytes[210] = length > 210 ? (byte)value[210] : (byte)0;
            Bytes[211] = length > 211 ? (byte)value[211] : (byte)0;
            Bytes[212] = length > 212 ? (byte)value[212] : (byte)0;
            Bytes[213] = length > 213 ? (byte)value[213] : (byte)0;
            Bytes[214] = length > 214 ? (byte)value[214] : (byte)0;
            Bytes[215] = length > 215 ? (byte)value[215] : (byte)0;
            Bytes[216] = length > 216 ? (byte)value[216] : (byte)0;
            Bytes[217] = length > 217 ? (byte)value[217] : (byte)0;
            Bytes[218] = length > 218 ? (byte)value[218] : (byte)0;
            Bytes[219] = length > 219 ? (byte)value[219] : (byte)0;
            Bytes[220] = length > 220 ? (byte)value[220] : (byte)0;
            Bytes[221] = length > 221 ? (byte)value[221] : (byte)0;
            Bytes[222] = length > 222 ? (byte)value[222] : (byte)0;
            Bytes[223] = length > 223 ? (byte)value[223] : (byte)0;
            Bytes[224] = length > 224 ? (byte)value[224] : (byte)0;
            Bytes[225] = length > 225 ? (byte)value[225] : (byte)0;
            Bytes[226] = length > 226 ? (byte)value[226] : (byte)0;
            Bytes[227] = length > 227 ? (byte)value[227] : (byte)0;
            Bytes[228] = length > 228 ? (byte)value[228] : (byte)0;
            Bytes[229] = length > 229 ? (byte)value[229] : (byte)0;
            Bytes[230] = length > 230 ? (byte)value[230] : (byte)0;
            Bytes[231] = length > 231 ? (byte)value[231] : (byte)0;
            Bytes[232] = length > 232 ? (byte)value[232] : (byte)0;
            Bytes[233] = length > 233 ? (byte)value[233] : (byte)0;
            Bytes[234] = length > 234 ? (byte)value[234] : (byte)0;
            Bytes[235] = length > 235 ? (byte)value[235] : (byte)0;
            Bytes[236] = length > 236 ? (byte)value[236] : (byte)0;
            Bytes[237] = length > 237 ? (byte)value[237] : (byte)0;
            Bytes[238] = length > 238 ? (byte)value[238] : (byte)0;
            Bytes[239] = length > 239 ? (byte)value[239] : (byte)0;
            Bytes[240] = length > 240 ? (byte)value[240] : (byte)0;
            Bytes[241] = length > 241 ? (byte)value[241] : (byte)0;
            Bytes[242] = length > 242 ? (byte)value[242] : (byte)0;
            Bytes[243] = length > 243 ? (byte)value[243] : (byte)0;
            Bytes[244] = length > 244 ? (byte)value[244] : (byte)0;
            Bytes[245] = length > 245 ? (byte)value[245] : (byte)0;
            Bytes[246] = length > 246 ? (byte)value[246] : (byte)0;
            Bytes[247] = length > 247 ? (byte)value[247] : (byte)0;
            Bytes[248] = length > 248 ? (byte)value[248] : (byte)0;
            Bytes[249] = length > 249 ? (byte)value[249] : (byte)0;
            Bytes[250] = length > 250 ? (byte)value[250] : (byte)0;
            Bytes[251] = length > 251 ? (byte)value[251] : (byte)0;
            Bytes[252] = length > 252 ? (byte)value[252] : (byte)0;
            Bytes[253] = length > 253 ? (byte)value[253] : (byte)0;
            Bytes[254] = length > 254 ? (byte)value[254] : (byte)0;
            Bytes[255] = length > 255 ? (byte)value[255] : (byte)0;
            Bytes[256] = length > 256 ? (byte)value[256] : (byte)0;
            Bytes[257] = length > 257 ? (byte)value[257] : (byte)0;
            Bytes[258] = length > 258 ? (byte)value[258] : (byte)0;
            Bytes[259] = length > 259 ? (byte)value[259] : (byte)0;
            Bytes[260] = length > 260 ? (byte)value[260] : (byte)0;
            Bytes[261] = length > 261 ? (byte)value[261] : (byte)0;
            Bytes[262] = length > 262 ? (byte)value[262] : (byte)0;
            Bytes[263] = length > 263 ? (byte)value[263] : (byte)0;
            Bytes[264] = length > 264 ? (byte)value[264] : (byte)0;
            Bytes[265] = length > 265 ? (byte)value[265] : (byte)0;
            Bytes[266] = length > 266 ? (byte)value[266] : (byte)0;
            Bytes[267] = length > 267 ? (byte)value[267] : (byte)0;
            Bytes[268] = length > 268 ? (byte)value[268] : (byte)0;
            Bytes[269] = length > 269 ? (byte)value[269] : (byte)0;
            Bytes[270] = length > 270 ? (byte)value[270] : (byte)0;
            Bytes[271] = length > 271 ? (byte)value[271] : (byte)0;
            Bytes[272] = length > 272 ? (byte)value[272] : (byte)0;
            Bytes[273] = length > 273 ? (byte)value[273] : (byte)0;
            Bytes[274] = length > 274 ? (byte)value[274] : (byte)0;
            Bytes[275] = length > 275 ? (byte)value[275] : (byte)0;
            Bytes[276] = length > 276 ? (byte)value[276] : (byte)0;
            Bytes[277] = length > 277 ? (byte)value[277] : (byte)0;
            Bytes[278] = length > 278 ? (byte)value[278] : (byte)0;
            Bytes[279] = length > 279 ? (byte)value[279] : (byte)0;
            Bytes[280] = length > 280 ? (byte)value[280] : (byte)0;
            Bytes[281] = length > 281 ? (byte)value[281] : (byte)0;
            Bytes[282] = length > 282 ? (byte)value[282] : (byte)0;
            Bytes[283] = length > 283 ? (byte)value[283] : (byte)0;
            Bytes[284] = length > 284 ? (byte)value[284] : (byte)0;
            Bytes[285] = length > 285 ? (byte)value[285] : (byte)0;
            Bytes[286] = length > 286 ? (byte)value[286] : (byte)0;
            Bytes[287] = length > 287 ? (byte)value[287] : (byte)0;
            Bytes[288] = length > 288 ? (byte)value[288] : (byte)0;
            Bytes[289] = length > 289 ? (byte)value[289] : (byte)0;
            Bytes[290] = length > 290 ? (byte)value[290] : (byte)0;
            Bytes[291] = length > 291 ? (byte)value[291] : (byte)0;
            Bytes[292] = length > 292 ? (byte)value[292] : (byte)0;
            Bytes[293] = length > 293 ? (byte)value[293] : (byte)0;
            Bytes[294] = length > 294 ? (byte)value[294] : (byte)0;
            Bytes[295] = length > 295 ? (byte)value[295] : (byte)0;
            Bytes[296] = length > 296 ? (byte)value[296] : (byte)0;
            Bytes[297] = length > 297 ? (byte)value[297] : (byte)0;
            Bytes[298] = length > 298 ? (byte)value[298] : (byte)0;
            Bytes[299] = length > 299 ? (byte)value[299] : (byte)0;
            Bytes[300] = length > 300 ? (byte)value[300] : (byte)0;
            Bytes[301] = length > 301 ? (byte)value[301] : (byte)0;
            Bytes[302] = length > 302 ? (byte)value[302] : (byte)0;
            Bytes[303] = length > 303 ? (byte)value[303] : (byte)0;
            Bytes[304] = length > 304 ? (byte)value[304] : (byte)0;
            Bytes[305] = length > 305 ? (byte)value[305] : (byte)0;
            Bytes[306] = length > 306 ? (byte)value[306] : (byte)0;
            Bytes[307] = length > 307 ? (byte)value[307] : (byte)0;
            Bytes[308] = length > 308 ? (byte)value[308] : (byte)0;
            Bytes[309] = length > 309 ? (byte)value[309] : (byte)0;
            Bytes[310] = length > 310 ? (byte)value[310] : (byte)0;
            Bytes[311] = length > 311 ? (byte)value[311] : (byte)0;
            Bytes[312] = length > 312 ? (byte)value[312] : (byte)0;
            Bytes[313] = length > 313 ? (byte)value[313] : (byte)0;
            Bytes[314] = length > 314 ? (byte)value[314] : (byte)0;
            Bytes[315] = length > 315 ? (byte)value[315] : (byte)0;
            Bytes[316] = length > 316 ? (byte)value[316] : (byte)0;
            Bytes[317] = length > 317 ? (byte)value[317] : (byte)0;
            Bytes[318] = length > 318 ? (byte)value[318] : (byte)0;
            Bytes[319] = length > 319 ? (byte)value[319] : (byte)0;
            Bytes[320] = length > 320 ? (byte)value[320] : (byte)0;
            Bytes[321] = length > 321 ? (byte)value[321] : (byte)0;
            Bytes[322] = length > 322 ? (byte)value[322] : (byte)0;
            Bytes[323] = length > 323 ? (byte)value[323] : (byte)0;
            Bytes[324] = length > 324 ? (byte)value[324] : (byte)0;
            Bytes[325] = length > 325 ? (byte)value[325] : (byte)0;
            Bytes[326] = length > 326 ? (byte)value[326] : (byte)0;
            Bytes[327] = length > 327 ? (byte)value[327] : (byte)0;
            Bytes[328] = length > 328 ? (byte)value[328] : (byte)0;
            Bytes[329] = length > 329 ? (byte)value[329] : (byte)0;
            Bytes[330] = length > 330 ? (byte)value[330] : (byte)0;
            Bytes[331] = length > 331 ? (byte)value[331] : (byte)0;
            Bytes[332] = length > 332 ? (byte)value[332] : (byte)0;
            Bytes[333] = length > 333 ? (byte)value[333] : (byte)0;
            Bytes[334] = length > 334 ? (byte)value[334] : (byte)0;
            Bytes[335] = length > 335 ? (byte)value[335] : (byte)0;
            Bytes[336] = length > 336 ? (byte)value[336] : (byte)0;
            Bytes[337] = length > 337 ? (byte)value[337] : (byte)0;
            Bytes[338] = length > 338 ? (byte)value[338] : (byte)0;
            Bytes[339] = length > 339 ? (byte)value[339] : (byte)0;
            Bytes[340] = length > 340 ? (byte)value[340] : (byte)0;
            Bytes[341] = length > 341 ? (byte)value[341] : (byte)0;
            Bytes[342] = length > 342 ? (byte)value[342] : (byte)0;
            Bytes[343] = length > 343 ? (byte)value[343] : (byte)0;
            Bytes[344] = length > 344 ? (byte)value[344] : (byte)0;
            Bytes[345] = length > 345 ? (byte)value[345] : (byte)0;
            Bytes[346] = length > 346 ? (byte)value[346] : (byte)0;
            Bytes[347] = length > 347 ? (byte)value[347] : (byte)0;
            Bytes[348] = length > 348 ? (byte)value[348] : (byte)0;
            Bytes[349] = length > 349 ? (byte)value[349] : (byte)0;
            Bytes[350] = length > 350 ? (byte)value[350] : (byte)0;
            Bytes[351] = length > 351 ? (byte)value[351] : (byte)0;
            Bytes[352] = length > 352 ? (byte)value[352] : (byte)0;
            Bytes[353] = length > 353 ? (byte)value[353] : (byte)0;
            Bytes[354] = length > 354 ? (byte)value[354] : (byte)0;
            Bytes[355] = length > 355 ? (byte)value[355] : (byte)0;
            Bytes[356] = length > 356 ? (byte)value[356] : (byte)0;
            Bytes[357] = length > 357 ? (byte)value[357] : (byte)0;
            Bytes[358] = length > 358 ? (byte)value[358] : (byte)0;
            Bytes[359] = length > 359 ? (byte)value[359] : (byte)0;
            Bytes[360] = length > 360 ? (byte)value[360] : (byte)0;
            Bytes[361] = length > 361 ? (byte)value[361] : (byte)0;
            Bytes[362] = length > 362 ? (byte)value[362] : (byte)0;
            Bytes[363] = length > 363 ? (byte)value[363] : (byte)0;
            Bytes[364] = length > 364 ? (byte)value[364] : (byte)0;
            Bytes[365] = length > 365 ? (byte)value[365] : (byte)0;
            Bytes[366] = length > 366 ? (byte)value[366] : (byte)0;
            Bytes[367] = length > 367 ? (byte)value[367] : (byte)0;
            Bytes[368] = length > 368 ? (byte)value[368] : (byte)0;
            Bytes[369] = length > 369 ? (byte)value[369] : (byte)0;
            Bytes[370] = length > 370 ? (byte)value[370] : (byte)0;
            Bytes[371] = length > 371 ? (byte)value[371] : (byte)0;
            Bytes[372] = length > 372 ? (byte)value[372] : (byte)0;
            Bytes[373] = length > 373 ? (byte)value[373] : (byte)0;
            Bytes[374] = length > 374 ? (byte)value[374] : (byte)0;
            Bytes[375] = length > 375 ? (byte)value[375] : (byte)0;
            Bytes[376] = length > 376 ? (byte)value[376] : (byte)0;
            Bytes[377] = length > 377 ? (byte)value[377] : (byte)0;
            Bytes[378] = length > 378 ? (byte)value[378] : (byte)0;
            Bytes[379] = length > 379 ? (byte)value[379] : (byte)0;
            Bytes[380] = length > 380 ? (byte)value[380] : (byte)0;
            Bytes[381] = length > 381 ? (byte)value[381] : (byte)0;
            Bytes[382] = length > 382 ? (byte)value[382] : (byte)0;
            Bytes[383] = length > 383 ? (byte)value[383] : (byte)0;
            Bytes[384] = length > 384 ? (byte)value[384] : (byte)0;
            Bytes[385] = length > 385 ? (byte)value[385] : (byte)0;
            Bytes[386] = length > 386 ? (byte)value[386] : (byte)0;
            Bytes[387] = length > 387 ? (byte)value[387] : (byte)0;
            Bytes[388] = length > 388 ? (byte)value[388] : (byte)0;
            Bytes[389] = length > 389 ? (byte)value[389] : (byte)0;
            Bytes[390] = length > 390 ? (byte)value[390] : (byte)0;
            Bytes[391] = length > 391 ? (byte)value[391] : (byte)0;
            Bytes[392] = length > 392 ? (byte)value[392] : (byte)0;
            Bytes[393] = length > 393 ? (byte)value[393] : (byte)0;
            Bytes[394] = length > 394 ? (byte)value[394] : (byte)0;
            Bytes[395] = length > 395 ? (byte)value[395] : (byte)0;
            Bytes[396] = length > 396 ? (byte)value[396] : (byte)0;
            Bytes[397] = length > 397 ? (byte)value[397] : (byte)0;
            Bytes[398] = length > 398 ? (byte)value[398] : (byte)0;
            Bytes[399] = length > 399 ? (byte)value[399] : (byte)0;
            Bytes[400] = length > 400 ? (byte)value[400] : (byte)0;
            Bytes[401] = length > 401 ? (byte)value[401] : (byte)0;
            Bytes[402] = length > 402 ? (byte)value[402] : (byte)0;
            Bytes[403] = length > 403 ? (byte)value[403] : (byte)0;
            Bytes[404] = length > 404 ? (byte)value[404] : (byte)0;
            Bytes[405] = length > 405 ? (byte)value[405] : (byte)0;
            Bytes[406] = length > 406 ? (byte)value[406] : (byte)0;
            Bytes[407] = length > 407 ? (byte)value[407] : (byte)0;
            Bytes[408] = length > 408 ? (byte)value[408] : (byte)0;
            Bytes[409] = length > 409 ? (byte)value[409] : (byte)0;
            Bytes[410] = length > 410 ? (byte)value[410] : (byte)0;
            Bytes[411] = length > 411 ? (byte)value[411] : (byte)0;
            Bytes[412] = length > 412 ? (byte)value[412] : (byte)0;
            Bytes[413] = length > 413 ? (byte)value[413] : (byte)0;
            Bytes[414] = length > 414 ? (byte)value[414] : (byte)0;
            Bytes[415] = length > 415 ? (byte)value[415] : (byte)0;
            Bytes[416] = length > 416 ? (byte)value[416] : (byte)0;
            Bytes[417] = length > 417 ? (byte)value[417] : (byte)0;
            Bytes[418] = length > 418 ? (byte)value[418] : (byte)0;
            Bytes[419] = length > 419 ? (byte)value[419] : (byte)0;
            Bytes[420] = length > 420 ? (byte)value[420] : (byte)0;
            Bytes[421] = length > 421 ? (byte)value[421] : (byte)0;
            Bytes[422] = length > 422 ? (byte)value[422] : (byte)0;
            Bytes[423] = length > 423 ? (byte)value[423] : (byte)0;
            Bytes[424] = length > 424 ? (byte)value[424] : (byte)0;
            Bytes[425] = length > 425 ? (byte)value[425] : (byte)0;
            Bytes[426] = length > 426 ? (byte)value[426] : (byte)0;
            Bytes[427] = length > 427 ? (byte)value[427] : (byte)0;
            Bytes[428] = length > 428 ? (byte)value[428] : (byte)0;
            Bytes[429] = length > 429 ? (byte)value[429] : (byte)0;
            Bytes[430] = length > 430 ? (byte)value[430] : (byte)0;
            Bytes[431] = length > 431 ? (byte)value[431] : (byte)0;
            Bytes[432] = length > 432 ? (byte)value[432] : (byte)0;
            Bytes[433] = length > 433 ? (byte)value[433] : (byte)0;
            Bytes[434] = length > 434 ? (byte)value[434] : (byte)0;
            Bytes[435] = length > 435 ? (byte)value[435] : (byte)0;
            Bytes[436] = length > 436 ? (byte)value[436] : (byte)0;
            Bytes[437] = length > 437 ? (byte)value[437] : (byte)0;
            Bytes[438] = length > 438 ? (byte)value[438] : (byte)0;
            Bytes[439] = length > 439 ? (byte)value[439] : (byte)0;
            Bytes[440] = length > 440 ? (byte)value[440] : (byte)0;
            Bytes[441] = length > 441 ? (byte)value[441] : (byte)0;
            Bytes[442] = length > 442 ? (byte)value[442] : (byte)0;
            Bytes[443] = length > 443 ? (byte)value[443] : (byte)0;
            Bytes[444] = length > 444 ? (byte)value[444] : (byte)0;
            Bytes[445] = length > 445 ? (byte)value[445] : (byte)0;
            Bytes[446] = length > 446 ? (byte)value[446] : (byte)0;
            Bytes[447] = length > 447 ? (byte)value[447] : (byte)0;
            Bytes[448] = length > 448 ? (byte)value[448] : (byte)0;
            Bytes[449] = length > 449 ? (byte)value[449] : (byte)0;
            Bytes[450] = length > 450 ? (byte)value[450] : (byte)0;
            Bytes[451] = length > 451 ? (byte)value[451] : (byte)0;
            Bytes[452] = length > 452 ? (byte)value[452] : (byte)0;
            Bytes[453] = length > 453 ? (byte)value[453] : (byte)0;
            Bytes[454] = length > 454 ? (byte)value[454] : (byte)0;
            Bytes[455] = length > 455 ? (byte)value[455] : (byte)0;
            Bytes[456] = length > 456 ? (byte)value[456] : (byte)0;
            Bytes[457] = length > 457 ? (byte)value[457] : (byte)0;
            Bytes[458] = length > 458 ? (byte)value[458] : (byte)0;
            Bytes[459] = length > 459 ? (byte)value[459] : (byte)0;
            Bytes[460] = length > 460 ? (byte)value[460] : (byte)0;
            Bytes[461] = length > 461 ? (byte)value[461] : (byte)0;
            Bytes[462] = length > 462 ? (byte)value[462] : (byte)0;
            Bytes[463] = length > 463 ? (byte)value[463] : (byte)0;
            Bytes[464] = length > 464 ? (byte)value[464] : (byte)0;
            Bytes[465] = length > 465 ? (byte)value[465] : (byte)0;
            Bytes[466] = length > 466 ? (byte)value[466] : (byte)0;
            Bytes[467] = length > 467 ? (byte)value[467] : (byte)0;
            Bytes[468] = length > 468 ? (byte)value[468] : (byte)0;
            Bytes[469] = length > 469 ? (byte)value[469] : (byte)0;
            Bytes[470] = length > 470 ? (byte)value[470] : (byte)0;
            Bytes[471] = length > 471 ? (byte)value[471] : (byte)0;
            Bytes[472] = length > 472 ? (byte)value[472] : (byte)0;
            Bytes[473] = length > 473 ? (byte)value[473] : (byte)0;
            Bytes[474] = length > 474 ? (byte)value[474] : (byte)0;
            Bytes[475] = length > 475 ? (byte)value[475] : (byte)0;
            Bytes[476] = length > 476 ? (byte)value[476] : (byte)0;
            Bytes[477] = length > 477 ? (byte)value[477] : (byte)0;
            Bytes[478] = length > 478 ? (byte)value[478] : (byte)0;
            Bytes[479] = length > 479 ? (byte)value[479] : (byte)0;
            Bytes[480] = length > 480 ? (byte)value[480] : (byte)0;
            Bytes[481] = length > 481 ? (byte)value[481] : (byte)0;
            Bytes[482] = length > 482 ? (byte)value[482] : (byte)0;
            Bytes[483] = length > 483 ? (byte)value[483] : (byte)0;
            Bytes[484] = length > 484 ? (byte)value[484] : (byte)0;
            Bytes[485] = length > 485 ? (byte)value[485] : (byte)0;
            Bytes[486] = length > 486 ? (byte)value[486] : (byte)0;
            Bytes[487] = length > 487 ? (byte)value[487] : (byte)0;
            Bytes[488] = length > 488 ? (byte)value[488] : (byte)0;
            Bytes[489] = length > 489 ? (byte)value[489] : (byte)0;
            Bytes[490] = length > 490 ? (byte)value[490] : (byte)0;
            Bytes[491] = length > 491 ? (byte)value[491] : (byte)0;
            Bytes[492] = length > 492 ? (byte)value[492] : (byte)0;
            Bytes[493] = length > 493 ? (byte)value[493] : (byte)0;
            Bytes[494] = length > 494 ? (byte)value[494] : (byte)0;
            Bytes[495] = length > 495 ? (byte)value[495] : (byte)0;
            Bytes[496] = length > 496 ? (byte)value[496] : (byte)0;
            Bytes[497] = length > 497 ? (byte)value[497] : (byte)0;
            Bytes[498] = length > 498 ? (byte)value[498] : (byte)0;
            Bytes[499] = length > 499 ? (byte)value[499] : (byte)0;
        }

        /// <summary>
        ///  Text 500 as string
        /// </summary>
        public readonly override string ToString()
            => Value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal fixed byte Bytes[Size];
    }
}
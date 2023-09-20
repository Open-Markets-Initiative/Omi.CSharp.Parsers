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
        ///  Does Text 500 field contain a value?
        /// </summary>
        public bool HasValue
            => Bytes[0] != 0;

        /// <summary>
        ///  Read Text 500 from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Length); }
        }

        /// <summary>
        ///  Try Read Text 500
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out string value)
        {
            value = Decode();
            return HasValue;
        }

        /// <summary>
        ///  Encode Text 500
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
        ///  Text 500 as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
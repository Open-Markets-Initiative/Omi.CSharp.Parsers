using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Password: User password in plain text
    /// </summary>
    public unsafe struct Password
    {
        /// <summary>
        ///  Size of Password underlying field in bytes
        /// </summary>
        public const int Size = 32;

        /// <summary>
        ///  Length of Password field
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

                return 32;
            }
        }

        /// <summary>
        ///  Password value
        /// </summary>
        public readonly string Value
            => Decode(this);

        /// <summary>
        ///  Does Password field contain a value?
        /// </summary>
        public bool HasValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return Bytes[0] != 0; }
        }

        /// <summary>
        ///  Read Password
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Decode(Password value)
            => new string((sbyte*)value.Bytes, 0, value.Length);

        /// <summary>
        ///  Try Read Password
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
        ///  Encode Password
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
        }

        /// <summary>
        ///  Password as string
        /// </summary>
        public override string ToString()
            => Value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal fixed byte Bytes[Size];
    }
}
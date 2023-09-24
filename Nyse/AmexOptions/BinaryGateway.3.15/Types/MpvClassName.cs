using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Mpv Class Name: Name of the Minimum Price Variant (MPV) Class.
    /// </summary>
    public unsafe struct MpvClassName
    {
        /// <summary>
        ///  Size of Mpv Class Name underlying field in bytes
        /// </summary>
        public const int Size = 20;

        /// <summary>
        ///  Length of Mpv Class Name field
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

                return 20;
            }
        }

        /// <summary>
        ///  Mpv Class Name value
        /// </summary>
        public readonly string Value
            => Decode(this);

        /// <summary>
        ///  Does Mpv Class Name field contain a value?
        /// </summary>
        public bool HasValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return Bytes[0] != (byte)' '; }
        }

        /// <summary>
        ///  Read Mpv Class Name
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Decode(MpvClassName value)
            => new string((sbyte*)value.Bytes, 0, value.Length);

        /// <summary>
        ///  Try Read Mpv Class Name
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
        ///  Encode Mpv Class Name
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
        }

        /// <summary>
        ///  Mpv Class Name as string
        /// </summary>
        public readonly override string ToString()
            => Value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal fixed byte Bytes[Size];
    }
}
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Listed Mic: Market Identifier Code (MIC) of Primary Market
    /// </summary>
    public unsafe struct ListedMic
    {
        /// <summary>
        ///  Size of Listed Mic underlying field in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Length of Listed Mic field
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

                return 4;
            }
        }

        /// <summary>
        ///  Listed Mic value
        /// </summary>
        public readonly string Value
            => Decode(this);

        /// <summary>
        ///  Does Listed Mic field contain a value?
        /// </summary>
        public bool HasValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return Bytes[0] != 0; }
        }

        /// <summary>
        ///  Read Listed Mic
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Decode(ListedMic value)
            => new string((sbyte*)value.Bytes, 0, value.Length);

        /// <summary>
        ///  Try Read Listed Mic
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
        ///  Encode Listed Mic
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(string value)
        {
            var length = value.Length;
            Bytes[0] = length > 0 ? (byte)value[0] : (byte)0;
            Bytes[1] = length > 1 ? (byte)value[1] : (byte)0;
            Bytes[2] = length > 2 ? (byte)value[2] : (byte)0;
            Bytes[3] = length > 3 ? (byte)value[3] : (byte)0;
        }

        /// <summary>
        ///  Listed Mic as string
        /// </summary>
        public readonly override string ToString()
            => Value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal fixed byte Bytes[Size];
    }
}
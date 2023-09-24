using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Mic: Market Identifier Code (MIC) of the connected market.
    /// </summary>
    public unsafe struct Mic
    {
        /// <summary>
        ///  Size of Mic underlying field in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Length of Mic field
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
        ///  Mic value
        /// </summary>
        public readonly string Value
            => Decode(this);

        /// <summary>
        ///  Does Mic field contain a value?
        /// </summary>
        public bool HasValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return Bytes[0] != (byte)' '; }
        }

        /// <summary>
        ///  Read Mic
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Decode(Mic value)
            => new string((sbyte*)value.Bytes, 0, value.Length);

        /// <summary>
        ///  Try Read Mic
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
        ///  Encode Mic
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
        ///  Mic as string
        /// </summary>
        public readonly override string ToString()
            => Value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal fixed byte Bytes[Size];
    }
}
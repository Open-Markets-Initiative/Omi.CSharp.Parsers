using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Security Exchange: Market used to help identify an instrument
    /// </summary>
    public unsafe struct SecurityExchange
    {
        /// <summary>
        ///  Fix Tag for Security Exchange
        /// </summary>
        public const ushort FixTag = 207;

        /// <summary>
        ///  Size of Security Exchange underlying field in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Length of Security Exchange field
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
        ///  Security Exchange value
        /// </summary>
        public readonly string Value
            => Decode(this);

        /// <summary>
        ///  Does Security Exchange field contain a value?
        /// </summary>
        public bool HasValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return Bytes[0] != 0; }
        }

        /// <summary>
        ///  Read Security Exchange
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Decode(SecurityExchange value)
            => new string((sbyte*)value.Bytes, 0, value.Length);

        /// <summary>
        ///  Try Read Security Exchange
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
        ///  Encode Security Exchange
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
        ///  Security Exchange as string
        /// </summary>
        public readonly override string ToString()
            => Value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal fixed byte Bytes[Size];
    }
}
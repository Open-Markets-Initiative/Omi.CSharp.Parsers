using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Security Sub Type: SecuritySubType for CDS only
    /// </summary>
    public unsafe struct SecuritySubType
    {
        /// <summary>
        ///  Fix Tag for Security Sub Type
        /// </summary>
        public const ushort FixTag = 762;

        /// <summary>
        ///  Size of Security Sub Type underlying field in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Length of Security Sub Type field
        /// </summary>
        public int Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Bytes[0] == 0) { return 0; }
                if (Bytes[1] == 0) { return 1; }

                return 2;
            }
        }

        /// <summary>
        ///  Security Sub Type value
        /// </summary>
        public readonly string Value
            => Decode(this);

        /// <summary>
        ///  Does Security Sub Type field contain a value?
        /// </summary>
        public bool HasValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return Bytes[0] != 0; }
        }

        /// <summary>
        ///  Read Security Sub Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Decode(SecuritySubType value)
            => new string((sbyte*)value.Bytes, 0, value.Length);

        /// <summary>
        ///  Try Read Security Sub Type
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
        ///  Encode Security Sub Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(string value)
        {
            var length = value.Length;
            Bytes[0] = length > 0 ? (byte)value[0] : (byte)0;
            Bytes[1] = length > 1 ? (byte)value[1] : (byte)0;
        }

        /// <summary>
        ///  Security Sub Type as string
        /// </summary>
        public readonly override string ToString()
            => Value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal fixed byte Bytes[Size];
    }
}
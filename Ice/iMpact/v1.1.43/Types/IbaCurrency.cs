using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Iba Currency: Currency Code
    /// </summary>
    public unsafe struct IbaCurrency
    {
        /// <summary>
        ///  Size of Iba Currency underlying field in bytes
        /// </summary>
        public const int Size = 3;

        /// <summary>
        ///  Length of Iba Currency field
        /// </summary>
        public int Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Bytes[0] == 0) { return 0; }
                if (Bytes[1] == 0) { return 1; }
                if (Bytes[2] == 0) { return 2; }

                return 3;
            }
        }

        /// <summary>
        ///  Does Iba Currency field contain a value?
        /// </summary>
        public bool HasValue
            => Bytes[0] != 0;

        /// <summary>
        ///  Read Iba Currency from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Length); }
        }

        /// <summary>
        ///  Try Read Iba Currency
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out string value)
        {
            value = Decode();
            return HasValue;
        }

        /// <summary>
        ///  Encode Iba Currency
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
        ///  Iba Currency as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
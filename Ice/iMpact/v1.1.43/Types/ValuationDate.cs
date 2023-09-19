using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Valuation Date: The date this price is effective for, in the format of YYYY-MM-DD
    /// </summary>
    public unsafe struct ValuationDate
    {
        /// <summary>
        ///  Length of Valuation Date in bytes
        /// </summary>
        public const int Size = 10;

        /// <summary>
        ///  Read Valuation Date from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Valuation Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Encode(string value)
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
        ///  Valuation Date as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
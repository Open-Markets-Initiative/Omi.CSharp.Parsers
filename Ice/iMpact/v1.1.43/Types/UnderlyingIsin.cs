using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Underlying Isin: The ISIN of the security this market is associated with. This is currently only populated for Liffe Equity markets.
    /// </summary>
    public unsafe struct UnderlyingIsin
    {
        /// <summary>
        ///  Length of Underlying Isin in bytes
        /// </summary>
        public const int Size = 12;

        /// <summary>
        ///  Read Underlying Isin from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Underlying Isin
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
        ///  Underlying Isin as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
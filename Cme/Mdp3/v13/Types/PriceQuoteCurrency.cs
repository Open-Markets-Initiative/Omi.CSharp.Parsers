using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Price Quote Currency: Local (counter) currency
    /// </summary>
    public unsafe struct PriceQuoteCurrency
    {
        /// <summary>
        ///  Fix Tag for Price Quote Currency
        /// </summary>
        public const ushort FixTag = 1524;

        /// <summary>
        ///  Size of Price Quote Currency underlying field in bytes
        /// </summary>
        public const int Size = 3;

        /// <summary>
        ///  Read Price Quote Currency from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Price Quote Currency
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
        ///  Price Quote Currency as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
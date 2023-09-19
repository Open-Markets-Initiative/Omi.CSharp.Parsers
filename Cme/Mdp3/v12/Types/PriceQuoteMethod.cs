using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Price Quote Method: Price quotation method
    /// </summary>
    public unsafe struct PriceQuoteMethod
    {
        /// <summary>
        ///  Fix Tag for Price Quote Method
        /// </summary>
        public const ushort FixTag = 1196;

        /// <summary>
        ///  Length of Price Quote Method in bytes
        /// </summary>
        public const int Size = 5;

        /// <summary>
        ///  Read Price Quote Method from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Price Quote Method
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
        ///  Price Quote Method as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
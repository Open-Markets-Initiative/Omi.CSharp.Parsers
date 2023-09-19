using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Quote Req Id: Quote Request ID defined by the exchange
    /// </summary>
    public unsafe struct QuoteReqId
    {
        /// <summary>
        ///  Fix Tag for Quote Req Id
        /// </summary>
        public const ushort FixTag = 131;

        /// <summary>
        ///  Length of Quote Req Id in bytes
        /// </summary>
        public const int Size = 23;

        /// <summary>
        ///  Read Quote Req Id from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Quote Req Id
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
        ///  Quote Req Id as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
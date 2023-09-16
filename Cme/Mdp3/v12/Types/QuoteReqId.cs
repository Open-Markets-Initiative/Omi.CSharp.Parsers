using System;
using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Quote Req Id: Quote Request ID defined by the exchange
    /// </summary>
    public struct QuoteReqId
    {
        /// <summary>
        ///  Fix Tag for Quote Req Id
        /// </summary>
        public const ushort FixTag = 131;

        /// <summary>
        ///  Length of Quote Req Id in bytes
        /// </summary>
        public const int Length = 23;

        /// <summary>
        ///  Read Quote Req Id from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Quote Req Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Encode(string value)
        {
            var end = Math.Min(value.Length, Length);

            for (var i = 0; i < end; i++)
            {
                Buffer[i] = (byte)value[i];
            }

            for (var i = end; i < Length; i++)
            {
                Buffer[i] = 0;
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
        internal unsafe fixed byte Buffer[Length];
    }
}
using System;
using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Price Quote Currency: Local (counter) currency
    /// </summary>
    public struct PriceQuoteCurrency
    {
        /// <summary>
        ///  Fix Tag for Price Quote Currency
        /// </summary>
        public const ushort FixTag = 1524;

        /// <summary>
        ///  Length of Price Quote Currency in bytes
        /// </summary>
        public const int Length = 3;

        /// <summary>
        ///  Read Price Quote Currency from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Price Quote Currency
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
        ///  Price Quote Currency as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}
using System;
using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Currency: Identifies the currency for the instrument traded.
    /// </summary>
    public struct Currency
    {
        /// <summary>
        ///  Fix Tag for Currency
        /// </summary>
        public const ushort FixTag = 15;

        /// <summary>
        ///  Length of Currency in bytes
        /// </summary>
        public const int Length = 3;

        /// <summary>
        ///  Read Currency from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Currency
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
        ///  Currency as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}
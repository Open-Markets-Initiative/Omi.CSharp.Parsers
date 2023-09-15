using System;
using System.Runtime.CompilerServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Price Quote Method: Price quotation method
    /// </summary>
    public struct PriceQuoteMethod
    {
        /// <summary>
        ///  Fix Tag for Price Quote Method
        /// </summary>
        public const ushort FixTag = 1196;

        /// <summary>
        ///  Length of Price Quote Method in bytes
        /// </summary>
        public const int Length = 5;

        /// <summary>
        ///  Read Price Quote Method from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Price Quote Method
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
        ///  Price Quote Method as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}
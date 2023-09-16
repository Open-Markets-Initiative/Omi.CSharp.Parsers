using System;
using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Leg Currency: Currency associated with a particular Leg's quantity
    /// </summary>
    public struct LegCurrency
    {
        /// <summary>
        ///  Fix Tag for Leg Currency
        /// </summary>
        public const ushort FixTag = 556;

        /// <summary>
        ///  Length of Leg Currency in bytes
        /// </summary>
        public const int Length = 3;

        /// <summary>
        ///  Read Leg Currency from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Leg Currency
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
        ///  Leg Currency as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}
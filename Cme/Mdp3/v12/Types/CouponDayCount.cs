using System;
using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Coupon Day Count: The day count convention used in interest calculations for a bond or an interest bearing security
    /// </summary>
    public struct CouponDayCount
    {
        /// <summary>
        ///  Fix Tag for Coupon Day Count
        /// </summary>
        public const ushort FixTag = 1950;

        /// <summary>
        ///  Length of Coupon Day Count in bytes
        /// </summary>
        public const int Length = 20;

        /// <summary>
        ///  Read Coupon Day Count from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Coupon Day Count
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
        ///  Coupon Day Count as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}
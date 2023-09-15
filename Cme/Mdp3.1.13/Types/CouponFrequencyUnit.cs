using System;
using System.Runtime.CompilerServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Coupon Frequency Unit: Time unit associated with the frequency of the bond's coupon payment
    /// </summary>
    public struct CouponFrequencyUnit
    {
        /// <summary>
        ///  Fix Tag for Coupon Frequency Unit
        /// </summary>
        public const ushort FixTag = 1949;

        /// <summary>
        ///  Length of Coupon Frequency Unit in bytes
        /// </summary>
        public const int Length = 3;

        /// <summary>
        ///  Read Coupon Frequency Unit from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Coupon Frequency Unit
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
        ///  Coupon Frequency Unit as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}
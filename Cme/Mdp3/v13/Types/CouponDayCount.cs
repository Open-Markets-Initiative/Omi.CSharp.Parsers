using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Coupon Day Count: The day count convention used in interest calculations for a bond or an interest bearing security
    /// </summary>
    public unsafe struct CouponDayCount
    {
        /// <summary>
        ///  Fix Tag for Coupon Day Count
        /// </summary>
        public const ushort FixTag = 1950;

        /// <summary>
        ///  Length of Coupon Day Count in bytes
        /// </summary>
        public const int Size = 20;

        /// <summary>
        ///  Read Coupon Day Count from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Coupon Day Count
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
        ///  Coupon Day Count as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
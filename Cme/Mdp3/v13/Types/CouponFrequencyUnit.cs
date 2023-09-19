using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Coupon Frequency Unit: Time unit associated with the frequency of the bond's coupon payment
    /// </summary>
    public unsafe struct CouponFrequencyUnit
    {
        /// <summary>
        ///  Fix Tag for Coupon Frequency Unit
        /// </summary>
        public const ushort FixTag = 1949;

        /// <summary>
        ///  Length of Coupon Frequency Unit in bytes
        /// </summary>
        public const int Size = 3;

        /// <summary>
        ///  Read Coupon Frequency Unit from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Coupon Frequency Unit
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
        ///  Coupon Frequency Unit as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Coupon Rate: The rate of interest that, when multiplied by the principal, par value, or face value of a bond, provides the currency amount of the periodic interest payment
    /// </summary>

    public unsafe struct CouponRate
    {
        /// <summary>
        ///  Fix Tag for Coupon Rate
        /// </summary>
        public const ushort FixTag = 223;

        /// <summary>
        ///  Decimal place factor for Coupon Rate
        /// </summary>
        public const long Factor = 1000000000;

        /// <summary>
        ///  Sentinel null value for Coupon Rate
        /// </summary>
        public const long NoValue = 9223372036854775807;

        /// <summary>
        ///  Size of Coupon Rate in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Coupon Rate
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return ((long)pointer) / Factor; }
        }

        /// <summary>
        ///  Try Read Coupon Rate
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out long value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Coupon Rate
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Set Coupon Rate to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Coupon Rate as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
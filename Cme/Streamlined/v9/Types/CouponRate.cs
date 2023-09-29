using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Coupon Rate: Coupon Rate of the Swap.
    /// </summary>

    public struct CouponRate
    {
        /// <summary>
        ///  Fix Tag for Coupon Rate
        /// </summary>
        public const ushort FixTag = 223;

        /// <summary>
        ///  Decimal place factor for Coupon Rate
        /// </summary>
        public const int Factor = 10000;

        /// <summary>
        ///  Sentinel null value for Coupon Rate
        /// </summary>
        public const int NoValue = 2147483647;

        /// <summary>
        ///  Size of Coupon Rate in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Coupon Rate value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Does Coupon Rate field contain a value?
        /// </summary>
        public readonly bool HasValue
            => Underlying != NoValue;

        /// <summary>
        ///  Read Coupon Rate
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Try Read Coupon Rate
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryRead(out int value)
        {
            if (HasValue)
            {
                value = Decode();
                return true;
            }

            value = default;
            return false;
        }

        /// <summary>
        ///  Write Coupon Rate
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Set Coupon Rate to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Coupon Rate as string
        /// </summary>
        public readonly override string ToString()
            => TryRead(out var value) ? $"{value}" : "Not Applicable";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}
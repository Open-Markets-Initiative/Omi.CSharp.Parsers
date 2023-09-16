using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Min Price: Minimum Price. OrderPriceDenominator should be applied to this field.
    /// </summary>

    public unsafe struct MinPrice
    {
        /// <summary>
        ///  Length of Min Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Min Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Min Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Value;
    }
}
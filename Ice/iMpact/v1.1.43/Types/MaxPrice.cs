using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Max Price: Maximum Price. OrderPriceDenominator should be applied to this field.
    /// </summary>

    public unsafe struct MaxPrice
    {
        /// <summary>
        ///  Length of Max Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Max Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Max Price
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
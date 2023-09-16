using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Low: DealPriceDenominator for the market should be applied to get the real price.
    /// </summary>

    public unsafe struct Low
    {
        /// <summary>
        ///  Length of Low in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Low
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Low
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
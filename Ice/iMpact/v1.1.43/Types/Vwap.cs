using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Vwap: Weighted Average Price. DealPriceDenominator for the market should be applied to get the real price.
    /// </summary>

    public unsafe struct Vwap
    {
        /// <summary>
        ///  Length of Vwap in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Vwap
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Vwap
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
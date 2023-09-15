using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Settlement Price With Deal Price Precision: DealPriceDenominator for the market should be applied to get this price.
    /// </summary>

    public unsafe struct SettlementPriceWithDealPricePrecision
    {
        /// <summary>
        ///  Length of Settlement Price With Deal Price Precision in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Settlement Price With Deal Price Precision
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Settlement Price With Deal Price Precision
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
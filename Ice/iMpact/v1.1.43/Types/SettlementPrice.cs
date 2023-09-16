using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Settlement Price: SettlePriceDenominator for the market should be applied to get the real settlement price.
    /// </summary>

    public unsafe struct SettlementPrice
    {
        /// <summary>
        ///  Length of Settlement Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Settlement Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Settlement Price
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
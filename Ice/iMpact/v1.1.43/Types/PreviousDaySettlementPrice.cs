using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Previous Day Settlement Price: SettlePriceDenominator for the market should be applied to get the real previous day settlement price.
    /// </summary>

    public unsafe struct PreviousDaySettlementPrice
    {
        /// <summary>
        ///  Length of Previous Day Settlement Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Previous Day Settlement Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Previous Day Settlement Price
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
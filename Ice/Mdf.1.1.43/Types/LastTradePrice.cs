using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Last Trade Price: DealPriceDenominator for the market should be applied to get the real price.
    /// </summary>

    public unsafe struct LastTradePrice
    {
        /// <summary>
        ///  Length of Last Trade Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Last Trade Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Last Trade Price
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
using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Price: DealPriceDenominator for the market should be applied to get the real price.
    /// </summary>

    public unsafe struct Price
    {
        /// <summary>
        ///  Length of Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Price
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
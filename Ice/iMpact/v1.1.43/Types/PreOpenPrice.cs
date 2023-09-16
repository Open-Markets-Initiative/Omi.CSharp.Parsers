using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Pre Open Price: DealPriceDenominator for the market should be applied to get the real price.
    /// </summary>

    public unsafe struct PreOpenPrice
    {
        /// <summary>
        ///  Length of Pre Open Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Pre Open Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Pre Open Price
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
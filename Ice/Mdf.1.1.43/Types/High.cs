using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  High: DealPriceDenominator for the market should be applied to get the real price.
    /// </summary>

    public unsafe struct High
    {
        /// <summary>
        ///  Length of High in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read High
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode High
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
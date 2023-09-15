using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Price In Gram: Auctioneers price in gram for the round in specified currency
    /// </summary>

    public unsafe struct PriceInGram
    {
        /// <summary>
        ///  Length of Price In Gram in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Price In Gram
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Price In Gram
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
using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Usd Price: Auctioneers price for the round in USD. Use 2 decimal places for USD Price.
    /// </summary>

    public unsafe struct UsdPrice
    {
        /// <summary>
        ///  Length of Usd Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Usd Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Usd Price
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
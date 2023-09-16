using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Increment Price: Minimum increment premium price for this market. OrderPriceDenominator should be applied to this field.
    /// </summary>

    public unsafe struct IncrementPrice
    {
        /// <summary>
        ///  Length of Increment Price in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Increment Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Increment Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Value;
    }
}
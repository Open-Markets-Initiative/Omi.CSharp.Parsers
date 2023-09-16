using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Increment Premium Price: Price increment for the option market.
    /// </summary>

    public unsafe struct IncrementPremiumPrice
    {
        /// <summary>
        ///  Length of Increment Premium Price in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Increment Premium Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Increment Premium Price
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
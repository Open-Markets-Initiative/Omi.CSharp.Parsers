using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Off Exchange Increment Price: Off exchange increment price.
    /// </summary>

    public unsafe struct OffExchangeIncrementPrice
    {
        /// <summary>
        ///  Length of Off Exchange Increment Price in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Off Exchange Increment Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Off Exchange Increment Price
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
using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Min Options Price: Minimum premium price for the option.
    /// </summary>

    public unsafe struct MinOptionsPrice
    {
        /// <summary>
        ///  Length of Min Options Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Min Options Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Min Options Price
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
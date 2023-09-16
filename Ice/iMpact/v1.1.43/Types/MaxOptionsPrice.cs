using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Max Options Price: Maximum premium price for the option.
    /// </summary>

    public unsafe struct MaxOptionsPrice
    {
        /// <summary>
        ///  Length of Max Options Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Max Options Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Max Options Price
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
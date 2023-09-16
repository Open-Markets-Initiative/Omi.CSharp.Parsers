using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Hedge Price: HedgePrice
    /// </summary>

    public unsafe struct HedgePrice
    {
        /// <summary>
        ///  Length of Hedge Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Hedge Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Hedge Price
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
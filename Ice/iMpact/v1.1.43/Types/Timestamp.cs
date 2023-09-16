using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Timestamp: Timestamp of last update used to derive the price level message. The format is nanoseconds since
    /// </summary>

    public unsafe struct Timestamp
    {
        /// <summary>
        ///  Length of Timestamp in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Timestamp
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Timestamp
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
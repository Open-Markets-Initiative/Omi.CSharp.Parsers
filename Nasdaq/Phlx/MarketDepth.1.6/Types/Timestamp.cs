using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Timestamp: Nanoseconds portion of the timestamp.
    /// </summary>

    public unsafe struct Timestamp
    {
        /// <summary>
        ///  Length of Timestamp in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Timestamp
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Timestamp
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Value;
    }
}
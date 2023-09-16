using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Sequence: Sequence Number of the first message to follow this header
    /// </summary>

    public unsafe struct Sequence
    {
        /// <summary>
        ///  Length of Sequence in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Sequence
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
            => Value;

        /// <summary>
        ///  Encode Sequence
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Value;
    }
}
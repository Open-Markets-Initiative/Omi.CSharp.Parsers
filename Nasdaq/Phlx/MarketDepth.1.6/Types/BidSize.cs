using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Bid Size: The bid contracts of the new quote.
    /// </summary>

    public unsafe struct BidSize
    {
        /// <summary>
        ///  Length of Bid Size in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Bid Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Bid Size
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
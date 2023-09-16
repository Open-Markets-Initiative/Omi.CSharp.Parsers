using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Short Bid Size: The bid contracts of the new quote.
    /// </summary>

    public unsafe struct ShortBidSize
    {
        /// <summary>
        ///  Length of Short Bid Size in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Short Bid Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
            => Value;

        /// <summary>
        ///  Encode Short Bid Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Value;
    }
}
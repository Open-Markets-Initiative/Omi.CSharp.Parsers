using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Bid Reference Number Delta: The bid reference number delta associated with the new quote.
    /// </summary>

    public unsafe struct BidReferenceNumberDelta
    {
        /// <summary>
        ///  Length of Bid Reference Number Delta in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Bid Reference Number Delta
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Bid Reference Number Delta
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
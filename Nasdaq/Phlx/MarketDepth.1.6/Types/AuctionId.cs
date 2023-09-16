using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Auction Id: Uniquely identifies the Auction for the trading day.
    /// </summary>

    public unsafe struct AuctionId
    {
        /// <summary>
        ///  Length of Auction Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Auction Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Auction Id
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
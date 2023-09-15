using System;
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Auction Id: CUBE Auction identifier supplied by Pillar Market Data to allow GTX responses to target specific CUBE auctions. If provided on non-GTX responses, the order will be rejected.
    /// </summary>

    public unsafe struct AuctionId
    {
        /// <summary>
        ///  Length of Auction Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Auction Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
            => Value;

        /// <summary>
        ///  Encode Auction Id
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
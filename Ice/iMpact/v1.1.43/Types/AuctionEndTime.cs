using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Auction End Time: Date time the Auction will end. Milliseconds since Jan 1st, 1970, 00:00:00 GMT
    /// </summary>

    public unsafe struct AuctionEndTime
    {
        /// <summary>
        ///  Length of Auction End Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Auction End Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Auction End Time
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
using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Agg Bid Qty: Aggregate bid quantity
    /// </summary>

    public unsafe struct AggBidQty
    {
        /// <summary>
        ///  Length of Agg Bid Qty in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Agg Bid Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Agg Bid Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Value;
    }
}
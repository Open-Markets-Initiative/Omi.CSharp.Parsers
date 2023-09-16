using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Agg Offer Qty: Aggregate offer quantity
    /// </summary>

    public unsafe struct AggOfferQty
    {
        /// <summary>
        ///  Length of Agg Offer Qty in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Agg Offer Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Agg Offer Qty
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
using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Min Qty: Minimum quantity for this market
    /// </summary>

    public unsafe struct MinQty
    {
        /// <summary>
        ///  Length of Min Qty in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Min Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Min Qty
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
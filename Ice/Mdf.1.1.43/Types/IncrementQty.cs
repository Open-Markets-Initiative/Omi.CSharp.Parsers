using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Increment Qty: Minimum increment quantity for this market
    /// </summary>

    public unsafe struct IncrementQty
    {
        /// <summary>
        ///  Length of Increment Qty in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Increment Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Increment Qty
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
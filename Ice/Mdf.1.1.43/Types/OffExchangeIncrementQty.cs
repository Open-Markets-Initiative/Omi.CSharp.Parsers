using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Off Exchange Increment Qty: Off exchange increment qty. OffExchangeIncrementQtyDenominator should be applied to this field.
    /// </summary>

    public unsafe struct OffExchangeIncrementQty
    {
        /// <summary>
        ///  Length of Off Exchange Increment Qty in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Off Exchange Increment Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Off Exchange Increment Qty
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
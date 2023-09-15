using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Tick Value: OrderPriceDenominator should be applied to get the real value.
    /// </summary>

    public unsafe struct TickValue
    {
        /// <summary>
        ///  Length of Tick Value in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Tick Value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Tick Value
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
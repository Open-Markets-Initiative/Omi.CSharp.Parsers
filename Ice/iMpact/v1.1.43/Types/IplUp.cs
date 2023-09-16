using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Ipl Up: IPL upper bound. OrderPriceDenominator for the market should be applied to get the real price limit. N/A when IPLHoldNotifyType = ‘E’
    /// </summary>

    public unsafe struct IplUp
    {
        /// <summary>
        ///  Length of Ipl Up in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Ipl Up
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Ipl Up
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
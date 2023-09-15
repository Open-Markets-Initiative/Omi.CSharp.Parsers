using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Trade Id: Unique identifier of the trade message, unique per market.
    /// </summary>

    public unsafe struct TradeId
    {
        /// <summary>
        ///  Length of Trade Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Trade Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Trade Id
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
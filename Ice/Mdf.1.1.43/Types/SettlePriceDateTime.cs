using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Settle Price Date Time: Milliseconds since Jan 1st, 1970, 00:00:00 GMT. If there is no settlement price, the value is -1.
    /// </summary>

    public unsafe struct SettlePriceDateTime
    {
        /// <summary>
        ///  Length of Settle Price Date Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Settle Price Date Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Settle Price Date Time
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
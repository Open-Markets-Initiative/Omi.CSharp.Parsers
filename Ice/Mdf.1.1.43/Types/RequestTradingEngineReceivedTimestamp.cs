using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Request Trading Engine Received Timestamp: This field can be used to get the time the trading engine received the request that triggers this message
    /// </summary>

    public unsafe struct RequestTradingEngineReceivedTimestamp
    {
        /// <summary>
        ///  Length of Request Trading Engine Received Timestamp in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Request Trading Engine Received Timestamp
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Request Trading Engine Received Timestamp
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
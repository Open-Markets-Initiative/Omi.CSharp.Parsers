using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Message Timestamp: Date time of the RFQ; milliseconds since Jan 1st, 1970, 00:00:00 GMT
    /// </summary>

    public unsafe struct MessageTimestamp
    {
        /// <summary>
        ///  Length of Message Timestamp in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Message Timestamp
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Message Timestamp
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
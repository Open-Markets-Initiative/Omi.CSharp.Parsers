using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Notification Date Time: Date time of the IPL Hold notification. Milliseconds since Jan 1st, 1970, 00:00:00 GMT
    /// </summary>

    public unsafe struct NotificationDateTime
    {
        /// <summary>
        ///  Length of Notification Date Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Notification Date Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Notification Date Time
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
using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Date Time: Date time the trade was investigated. Milliseconds since Jan 1st, 1970, 00:00:00 GMT
    /// </summary>

    public unsafe struct DateTime
    {
        /// <summary>
        ///  Length of Date Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Date Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Date Time
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
using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Delivery Begin Date Time: Delivery begin date time. Milliseconds since Jan 1st, 1970, 00:00:00 GMT
    /// </summary>

    public unsafe struct DeliveryBeginDateTime
    {
        /// <summary>
        ///  Length of Delivery Begin Date Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Delivery Begin Date Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Delivery Begin Date Time
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
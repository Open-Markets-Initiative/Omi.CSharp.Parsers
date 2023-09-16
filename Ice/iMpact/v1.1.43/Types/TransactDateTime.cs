using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Transact Date Time: Deal date time. Milliseconds since Jan 1st, 1970,
    /// </summary>

    public unsafe struct TransactDateTime
    {
        /// <summary>
        ///  Length of Transact Date Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Transact Date Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Transact Date Time
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
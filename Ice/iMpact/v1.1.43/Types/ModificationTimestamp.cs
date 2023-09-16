using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Modification Timestamp: This field can be used to get the order modification time
    /// </summary>

    public unsafe struct ModificationTimestamp
    {
        /// <summary>
        ///  Length of Modification Timestamp in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Modification Timestamp
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Modification Timestamp
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
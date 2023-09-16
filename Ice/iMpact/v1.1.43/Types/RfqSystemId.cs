using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Rfq System Id: System ID of the RFQ
    /// </summary>

    public unsafe struct RfqSystemId
    {
        /// <summary>
        ///  Length of Rfq System Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Rfq System Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Rfq System Id
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
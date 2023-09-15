using System;
using System.Runtime.CompilerServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Security Id:
    /// </summary>

    public unsafe struct SecurityId
    {
        /// <summary>
        ///  Length of Security Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Security Id
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
using System;
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Mm Sent Time: Customer provided sending time. CAT compliance Number of nanoseconds since Epoch.
    /// </summary>

    public unsafe struct MmSentTime
    {
        /// <summary>
        ///  Length of Mm Sent Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Mm Sent Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
            => Value;

        /// <summary>
        ///  Encode Mm Sent Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Value;
    }
}
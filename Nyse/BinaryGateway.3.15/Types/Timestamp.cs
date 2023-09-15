using System;
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Timestamp: Message timestamp
    /// </summary>

    public unsafe struct Timestamp
    {
        /// <summary>
        ///  Length of Timestamp in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Timestamp
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
            => Value;

        /// <summary>
        ///  Encode Timestamp
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
using System;
using System.Runtime.CompilerServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Transact Time:
    /// </summary>

    public unsafe struct TransactTime
    {
        /// <summary>
        ///  Length of Transact Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Transact Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
            => Value;

        /// <summary>
        ///  Encode Transact Time
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
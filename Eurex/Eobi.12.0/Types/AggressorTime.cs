using System;
using System.Runtime.CompilerServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Aggressor Time:
    /// </summary>

    public unsafe struct AggressorTime
    {
        /// <summary>
        ///  Length of Aggressor Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Aggressor Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
            => Value;

        /// <summary>
        ///  Encode Aggressor Time
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
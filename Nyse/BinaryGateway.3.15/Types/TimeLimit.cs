using System;
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Time Limit: Microsecond time period.
    /// </summary>

    public unsafe struct TimeLimit
    {
        /// <summary>
        ///  Length of Time Limit in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Time Limit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Time Limit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Value;
    }
}
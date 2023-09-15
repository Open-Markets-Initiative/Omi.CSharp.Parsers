using System;
using System.Runtime.CompilerServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Min Quote Life: Minimum Quote Life in number of microseconds
    /// </summary>

    public unsafe struct MinQuoteLife
    {
        /// <summary>
        ///  Fix Tag for Min Quote Life
        /// </summary>
        public const ushort FixTag = 37731;

        /// <summary>
        ///  Length of Min Quote Life in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Min Quote Life
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Min Quote Life
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Value;
    }
}
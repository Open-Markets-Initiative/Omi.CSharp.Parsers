using System;
using System.Runtime.CompilerServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  No Chunks: Total number of packets that constitutes a single instrument order book
    /// </summary>

    public unsafe struct NoChunks
    {
        /// <summary>
        ///  Fix Tag for No Chunks
        /// </summary>
        public const ushort FixTag = 37709;

        /// <summary>
        ///  Length of No Chunks in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read No Chunks
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode No Chunks
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
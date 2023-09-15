using System;
using System.Runtime.CompilerServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Current Chunk: Chunk sequence
    /// </summary>

    public unsafe struct CurrentChunk
    {
        /// <summary>
        ///  Fix Tag for Current Chunk
        /// </summary>
        public const ushort FixTag = 37710;

        /// <summary>
        ///  Length of Current Chunk in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Current Chunk
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Current Chunk
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
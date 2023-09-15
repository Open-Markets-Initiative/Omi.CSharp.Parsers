using System;
using System.Runtime.CompilerServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Md Entry Size: Cumulative traded volume
    /// </summary>

    public unsafe struct MdEntrySize
    {
        /// <summary>
        ///  Fix Tag for Md Entry Size
        /// </summary>
        public const ushort FixTag = 271;

        /// <summary>
        ///  Length of Md Entry Size in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Md Entry Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Md Entry Size
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
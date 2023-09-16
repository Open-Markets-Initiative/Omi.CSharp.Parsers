using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Sequence: TODO
    /// </summary>

    public unsafe struct Sequence
    {
        /// <summary>
        ///  Length of Sequence in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Sequence
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Sequence
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
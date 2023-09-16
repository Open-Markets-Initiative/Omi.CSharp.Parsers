using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Round:
    /// </summary>

    public unsafe struct Round
    {
        /// <summary>
        ///  Length of Round in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Round
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Round
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(short value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal short Value;
    }
}
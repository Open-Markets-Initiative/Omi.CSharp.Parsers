using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Fragment Offset: The index of the byte where this fragment starts within the total length of the fragmented message.
    /// </summary>

    public unsafe struct FragmentOffset
    {
        /// <summary>
        ///  Length of Fragment Offset in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Fragment Offset
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Fragment Offset
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
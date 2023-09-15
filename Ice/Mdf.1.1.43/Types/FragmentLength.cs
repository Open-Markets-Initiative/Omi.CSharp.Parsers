using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Fragment Length: The number of bytes in this fragment
    /// </summary>

    public unsafe struct FragmentLength
    {
        /// <summary>
        ///  Length of Fragment Length in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Fragment Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Fragment Length
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
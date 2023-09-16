using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Begin Month: Month range 1-12
    /// </summary>

    public unsafe struct BeginMonth
    {
        /// <summary>
        ///  Length of Begin Month in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Begin Month
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Begin Month
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
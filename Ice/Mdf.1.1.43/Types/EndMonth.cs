using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  End Month: Month range 1-12
    /// </summary>

    public unsafe struct EndMonth
    {
        /// <summary>
        ///  Length of End Month in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read End Month
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode End Month
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
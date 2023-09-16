using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Maturity Month: Month range 1-12
    /// </summary>

    public unsafe struct MaturityMonth
    {
        /// <summary>
        ///  Length of Maturity Month in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Maturity Month
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Maturity Month
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
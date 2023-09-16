using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Maturity Day:
    /// </summary>

    public unsafe struct MaturityDay
    {
        /// <summary>
        ///  Length of Maturity Day in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Maturity Day
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Maturity Day
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
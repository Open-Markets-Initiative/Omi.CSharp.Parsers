using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Delta: Apply 2 as the denominator to get the real value. For example, delta of 3.00 will be sent as 300.
    /// </summary>

    public unsafe struct Delta
    {
        /// <summary>
        ///  Length of Delta in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Delta
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Delta
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Value;
    }
}
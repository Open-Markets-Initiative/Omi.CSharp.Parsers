using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Volatility: Apply 2 as the denominator to get the real value. For example, volatility of 3.00 will be sent as 300.
    /// </summary>

    public unsafe struct Volatility
    {
        /// <summary>
        ///  Length of Volatility in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Volatility
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Volatility
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
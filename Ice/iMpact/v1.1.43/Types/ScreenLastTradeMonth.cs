using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Screen Last Trade Month: Screen last trade month, range 1-12
    /// </summary>

    public unsafe struct ScreenLastTradeMonth
    {
        /// <summary>
        ///  Length of Screen Last Trade Month in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Screen Last Trade Month
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Screen Last Trade Month
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
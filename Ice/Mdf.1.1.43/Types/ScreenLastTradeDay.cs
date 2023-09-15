using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Screen Last Trade Day: Screen last trade day of the month
    /// </summary>

    public unsafe struct ScreenLastTradeDay
    {
        /// <summary>
        ///  Length of Screen Last Trade Day in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Screen Last Trade Day
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Screen Last Trade Day
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
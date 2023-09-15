using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Ipl Hold Duration: Hold duration, in milliseconds. N/A when IPLHoldNotifyType = ‘E’
    /// </summary>

    public unsafe struct IplHoldDuration
    {
        /// <summary>
        ///  Length of Ipl Hold Duration in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Ipl Hold Duration
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Ipl Hold Duration
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Value;
    }
}
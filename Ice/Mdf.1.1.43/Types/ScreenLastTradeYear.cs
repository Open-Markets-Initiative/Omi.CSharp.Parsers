using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Screen Last Trade Year: Screen last trade year, 4 digits
    /// </summary>

    public unsafe struct ScreenLastTradeYear
    {
        /// <summary>
        ///  Length of Screen Last Trade Year in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Screen Last Trade Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Screen Last Trade Year
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
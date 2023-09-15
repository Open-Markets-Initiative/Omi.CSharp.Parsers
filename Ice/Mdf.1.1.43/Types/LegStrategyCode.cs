using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Leg Strategy Code: Leg Strategy Code
    /// </summary>

    public unsafe struct LegStrategyCode
    {
        /// <summary>
        ///  Length of Leg Strategy Code in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Leg Strategy Code
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Leg Strategy Code
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
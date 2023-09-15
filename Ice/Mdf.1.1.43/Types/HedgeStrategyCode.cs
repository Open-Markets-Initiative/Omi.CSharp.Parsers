using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Hedge Strategy Code: Hedge Strategy Code
    /// </summary>

    public unsafe struct HedgeStrategyCode
    {
        /// <summary>
        ///  Length of Hedge Strategy Code in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Hedge Strategy Code
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Hedge Strategy Code
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
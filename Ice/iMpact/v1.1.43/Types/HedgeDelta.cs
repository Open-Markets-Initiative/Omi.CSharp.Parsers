using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Hedge Delta: Hedge Delta
    /// </summary>

    public unsafe struct HedgeDelta
    {
        /// <summary>
        ///  Length of Hedge Delta in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Hedge Delta
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Hedge Delta
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
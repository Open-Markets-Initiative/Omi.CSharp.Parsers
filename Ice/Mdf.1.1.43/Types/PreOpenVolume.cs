using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Pre Open Volume: Indicative volume that would trade at the preOpenPrice
    /// </summary>

    public unsafe struct PreOpenVolume
    {
        /// <summary>
        ///  Length of Pre Open Volume in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Pre Open Volume
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Pre Open Volume
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
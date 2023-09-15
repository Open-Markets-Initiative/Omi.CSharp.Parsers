using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Efp Volume:
    /// </summary>

    public unsafe struct EfpVolume
    {
        /// <summary>
        ///  Length of Efp Volume in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Efp Volume
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Efp Volume
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
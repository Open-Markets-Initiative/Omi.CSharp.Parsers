using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Total Volume: N/A if set to -1
    /// </summary>

    public unsafe struct TotalVolume
    {
        /// <summary>
        ///  Length of Total Volume in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Total Volume
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Total Volume
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
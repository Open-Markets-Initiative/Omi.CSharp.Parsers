using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Efs Volume:
    /// </summary>

    public unsafe struct EfsVolume
    {
        /// <summary>
        ///  Length of Efs Volume in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Efs Volume
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Efs Volume
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
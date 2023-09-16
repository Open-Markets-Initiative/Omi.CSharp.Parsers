using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Volume: Electronic trade volume only, excluding block and other volumes.
    /// </summary>

    public unsafe struct Volume
    {
        /// <summary>
        ///  Length of Volume in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Volume
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Volume
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
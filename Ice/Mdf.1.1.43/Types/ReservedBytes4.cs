using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Reserved Bytes 4: Reserved for future use
    /// </summary>

    public unsafe struct ReservedBytes4
    {
        /// <summary>
        ///  Length of Reserved Bytes 4 in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Reserved Bytes 4
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Reserved Bytes 4
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
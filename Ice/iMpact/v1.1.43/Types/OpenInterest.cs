using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Open Interest:
    /// </summary>

    public unsafe struct OpenInterest
    {
        /// <summary>
        ///  Length of Open Interest in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Open Interest
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Open Interest
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
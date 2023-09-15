using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Open Interest Change:
    /// </summary>

    public unsafe struct OpenInterestChange
    {
        /// <summary>
        ///  Length of Open Interest Change in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Open Interest Change
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Open Interest Change
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
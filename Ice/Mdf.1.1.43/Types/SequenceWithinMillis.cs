using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Sequence Within Millis: Can be used in conjunction with TransactDateTime field for sequence of deals within same milliseconds time.
    /// </summary>

    public unsafe struct SequenceWithinMillis
    {
        /// <summary>
        ///  Length of Sequence Within Millis in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Sequence Within Millis
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Sequence Within Millis
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
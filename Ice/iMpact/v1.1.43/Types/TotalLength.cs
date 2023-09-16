using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Total Length: The total length of the fragmented message.
    /// </summary>

    public unsafe struct TotalLength
    {
        /// <summary>
        ///  Length of Total Length in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Total Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Total Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(short value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal short Value;
    }
}
using System;
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Next Seq: Next sequence number
    /// </summary>

    public unsafe struct NextSeq
    {
        /// <summary>
        ///  Length of Next Seq in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Next Seq
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
            => Value;

        /// <summary>
        ///  Encode Next Seq
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Value;
    }
}
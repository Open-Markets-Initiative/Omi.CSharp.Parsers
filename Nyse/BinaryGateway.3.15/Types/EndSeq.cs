using System;
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  End Seq: End sequence (ignored for write request)
    /// </summary>

    public unsafe struct EndSeq
    {
        /// <summary>
        ///  Length of End Seq in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read End Seq
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
            => Value;

        /// <summary>
        ///  Encode End Seq
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
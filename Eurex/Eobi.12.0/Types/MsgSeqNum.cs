using System;
using System.Runtime.CompilerServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Msg Seq Num:
    /// </summary>

    public unsafe struct MsgSeqNum
    {
        /// <summary>
        ///  Length of Msg Seq Num in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Msg Seq Num
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Msg Seq Num
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Value;
    }
}
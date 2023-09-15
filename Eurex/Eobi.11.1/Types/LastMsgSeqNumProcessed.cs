using System;
using System.Runtime.CompilerServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Last Msg Seq Num Processed:
    /// </summary>

    public unsafe struct LastMsgSeqNumProcessed
    {
        /// <summary>
        ///  Length of Last Msg Seq Num Processed in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Last Msg Seq Num Processed
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Last Msg Seq Num Processed
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
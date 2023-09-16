using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Last Msg Seq Num Processed: Sequence number of the last Incremental feed packet processed. This value is used to synchronize the snapshot loop with the real-time feed
    /// </summary>

    public unsafe struct LastMsgSeqNumProcessed
    {
        /// <summary>
        ///  Fix Tag for Last Msg Seq Num Processed
        /// </summary>
        public const ushort FixTag = 369;

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
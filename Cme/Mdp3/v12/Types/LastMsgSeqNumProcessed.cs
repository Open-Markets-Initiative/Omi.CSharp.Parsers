using System.Runtime.CompilerServices;

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
        ///  Size of Last Msg Seq Num Processed in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Last Msg Seq Num Processed
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
        {
            fixed (byte* pointer = Bytes) { return (uint)pointer; }
        }

        /// <summary>
        ///  Write Last Msg Seq Num Processed
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
        {
            fixed (byte* pointer = Bytes) { *(uint *)pointer = value; }
        }

        /// <summary>
        ///  Last Msg Seq Num Processed as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
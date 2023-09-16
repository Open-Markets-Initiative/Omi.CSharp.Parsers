using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Rpt Seq: Sequence number per Index update
    /// </summary>

    public unsafe struct RptSeq
    {
        /// <summary>
        ///  Fix Tag for Rpt Seq
        /// </summary>
        public const ushort FixTag = 83;

        /// <summary>
        ///  Length of Rpt Seq in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Rpt Seq
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Rpt Seq
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
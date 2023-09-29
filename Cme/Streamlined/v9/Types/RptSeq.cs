using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Rpt Seq: Sequence number per Index update
    /// </summary>

    public struct RptSeq
    {
        /// <summary>
        ///  Fix Tag for Rpt Seq
        /// </summary>
        public const ushort FixTag = 83;

        /// <summary>
        ///  Size of Rpt Seq in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Rpt Seq value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Rpt Seq
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write Rpt Seq
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Rpt Seq as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}
using System.Runtime.CompilerServices;

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
        ///  Size of Rpt Seq in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Rpt Seq
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
        {
            fixed (byte* pointer = Bytes) { return (uint)pointer; }
        }

        /// <summary>
        ///  Write Rpt Seq
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
        {
            fixed (byte* pointer = Bytes) { *(uint *)pointer = value; }
        }

        /// <summary>
        ///  Rpt Seq as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
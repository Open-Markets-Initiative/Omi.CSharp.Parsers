using System.Runtime.CompilerServices;;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Packet Sequence Number: Packet Sequence Number
    /// </summary>

    public unsafe struct PacketSequenceNumber
    {
        /// <summary>
        ///  Length of Packet Sequence Number in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Packet Sequence Number
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Packet Sequence Number
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
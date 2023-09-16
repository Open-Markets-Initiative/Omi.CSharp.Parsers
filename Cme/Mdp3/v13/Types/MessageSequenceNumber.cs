using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Message Sequence Number: Packet Sequence Number
    /// </summary>

    public unsafe struct MessageSequenceNumber
    {
        /// <summary>
        ///  Length of Message Sequence Number in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Message Sequence Number
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Message Sequence Number
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
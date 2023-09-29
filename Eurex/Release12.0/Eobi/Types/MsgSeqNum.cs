using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Msg Seq Num
    /// </summary>

    public struct MsgSeqNum
    {
        /// <summary>
        ///  Size of Msg Seq Num in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Msg Seq Num value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Msg Seq Num
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => Underlying;

        /// <summary>
        ///  Write Msg Seq Num
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = value;

        /// <summary>
        ///  Msg Seq Num as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}
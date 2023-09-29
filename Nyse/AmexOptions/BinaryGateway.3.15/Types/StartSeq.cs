using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Start Seq: Start sequence number
    /// </summary>

    public struct StartSeq
    {
        /// <summary>
        ///  Size of Start Seq in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Start Seq value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Start Seq
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying;

        /// <summary>
        ///  Write Start Seq
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value;

        /// <summary>
        ///  Start Seq as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}
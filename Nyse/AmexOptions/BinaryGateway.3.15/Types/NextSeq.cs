using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Next Seq: Next sequence number
    /// </summary>

    public struct NextSeq
    {
        /// <summary>
        ///  Size of Next Seq in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Next Seq value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Next Seq
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying;

        /// <summary>
        ///  Write Next Seq
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value;

        /// <summary>
        ///  Next Seq as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}
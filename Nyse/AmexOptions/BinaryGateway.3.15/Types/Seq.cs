using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Seq: Sequence number, starting from 1
    /// </summary>

    public struct Seq
    {
        /// <summary>
        ///  Size of Seq in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Seq value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Seq
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying;

        /// <summary>
        ///  Write Seq
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value;

        /// <summary>
        ///  Seq as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}
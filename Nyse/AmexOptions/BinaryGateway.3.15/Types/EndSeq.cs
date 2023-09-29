using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  End Seq: End sequence (ignored for write request)
    /// </summary>

    public struct EndSeq
    {
        /// <summary>
        ///  Size of End Seq in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  End Seq value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read End Seq
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying;

        /// <summary>
        ///  Write End Seq
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value;

        /// <summary>
        ///  End Seq as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}
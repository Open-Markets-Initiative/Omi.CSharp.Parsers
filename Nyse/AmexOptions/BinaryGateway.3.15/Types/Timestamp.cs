using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Timestamp: Message timestamp
    /// </summary>

    public struct Timestamp
    {
        /// <summary>
        ///  Size of Timestamp in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Timestamp value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Timestamp
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying;

        /// <summary>
        ///  Write Timestamp
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value;

        /// <summary>
        ///  Timestamp as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}
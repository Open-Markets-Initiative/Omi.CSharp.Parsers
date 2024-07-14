using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Modification Timestamp: This field can be used to get the order modification time
    /// </summary>

    public struct ModificationTimestamp
    {
        /// <summary>
        ///  Size of Modification Timestamp in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Modification Timestamp value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Read Modification Timestamp
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Modification Timestamp
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Modification Timestamp as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}
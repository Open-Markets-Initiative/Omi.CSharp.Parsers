using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Total Length: The total length of the fragmented message.
    /// </summary>

    public struct TotalLength
    {
        /// <summary>
        ///  Size of Total Length in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Total Length value
        /// </summary>
        public readonly short Value
            => Decode();

        /// <summary>
        ///  Read Total Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly short Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Total Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(short value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Total Length as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal short Underlying;
    }
}
using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Block Size: Size In Bytes Of Entire Transmission Block
    /// </summary>

    public struct BlockSize
    {
        /// <summary>
        ///  Size of Block Size in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Block Size value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Block Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Block Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Block Size as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}
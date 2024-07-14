using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Bid Size: The Bid Size Identifies The Number Of Contracts Being Bought For An Option At The Bid Price
    /// </summary>

    public struct BidSize
    {
        /// <summary>
        ///  Size of Bid Size in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Bid Size value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Bid Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Bid Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Bid Size as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}
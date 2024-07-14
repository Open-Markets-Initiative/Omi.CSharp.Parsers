using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Bid Size Short: The Bid Size Identifies The Number Of Contracts Being Bought For An Option At The Bid Price
    /// </summary>

    public struct BidSizeShort
    {
        /// <summary>
        ///  Size of Bid Size Short in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Bid Size Short value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Bid Size Short
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Bid Size Short
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Bid Size Short as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}
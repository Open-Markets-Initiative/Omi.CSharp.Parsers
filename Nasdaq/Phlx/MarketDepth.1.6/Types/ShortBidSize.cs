using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Short Bid Size: The bid contracts of the new quote.
    /// </summary>

    public struct ShortBidSize
    {
        /// <summary>
        ///  Size of Short Bid Size in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Short Bid Size value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Short Bid Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Short Bid Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Short Bid Size as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}
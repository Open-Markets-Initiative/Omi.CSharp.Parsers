using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Best Bid Price: Represents The Best Price At Which A Buyer Is Willing To Buy An Option
    /// </summary>

    public struct BestBidPrice
    {
        /// <summary>
        ///  Size of Best Bid Price in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Best Bid Price value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Best Bid Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Best Bid Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Best Bid Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}
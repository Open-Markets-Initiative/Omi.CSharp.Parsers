using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Bid Price: Represents The Price At Which A Buyer Is Willing To Buy An Option
    /// </summary>

    public struct BidPrice
    {
        /// <summary>
        ///  Size of Bid Price in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Bid Price value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Bid Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Bid Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Bid Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}
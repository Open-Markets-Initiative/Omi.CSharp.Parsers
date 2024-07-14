using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Opening Price: DealPriceDenominator for the market should be applied to get the real price.
    /// </summary>

    public struct OpeningPrice
    {
        /// <summary>
        ///  Size of Opening Price in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Opening Price value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Read Opening Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Opening Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Opening Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}
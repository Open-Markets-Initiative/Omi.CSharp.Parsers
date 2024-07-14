using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Settlement Price With Deal Price Precision: DealPriceDenominator for the market should be applied to get this price.
    /// </summary>

    public struct SettlementPriceWithDealPricePrecision
    {
        /// <summary>
        ///  Size of Settlement Price With Deal Price Precision in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Settlement Price With Deal Price Precision value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Read Settlement Price With Deal Price Precision
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Settlement Price With Deal Price Precision
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Settlement Price With Deal Price Precision as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}
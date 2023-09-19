using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Settlement Price With Deal Price Precision: DealPriceDenominator for the market should be applied to get this price.
    /// </summary>

    public unsafe struct SettlementPriceWithDealPricePrecision
    {
        /// <summary>
        ///  Length of Settlement Price With Deal Price Precision in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Settlement Price With Deal Price Precision
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((long)pointer); }
        }

        /// <summary>
        ///  Write Settlement Price With Deal Price Precision
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Settlement Price With Deal Price Precision as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
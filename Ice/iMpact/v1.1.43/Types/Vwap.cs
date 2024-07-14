using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Vwap: Weighted Average Price. DealPriceDenominator for the market should be applied to get the real price.
    /// </summary>

    public struct Vwap
    {
        /// <summary>
        ///  Size of Vwap in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Vwap value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Read Vwap
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Vwap
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Vwap as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}
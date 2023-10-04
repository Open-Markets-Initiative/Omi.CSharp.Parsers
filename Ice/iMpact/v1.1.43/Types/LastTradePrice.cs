using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Last Trade Price: DealPriceDenominator for the market should be applied to get the real price.
    /// </summary>

    public struct LastTradePrice
    {
        /// <summary>
        ///  Size of Last Trade Price in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Last Trade Price value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Read Last Trade Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Last Trade Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Set Last Trade Price to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Last Trade Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}
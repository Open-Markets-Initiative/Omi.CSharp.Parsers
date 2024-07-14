using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  High: DealPriceDenominator for the market should be applied to get the real price.
    /// </summary>

    public struct High
    {
        /// <summary>
        ///  Size of High in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  High value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Read High
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write High
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  High as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}
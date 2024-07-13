using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Best Offer Price: Represents The Best Price At Which A Seller Is Offering To Sell An Option
    /// </summary>

    public struct BestOfferPrice
    {
        /// <summary>
        ///  Size of Best Offer Price in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Best Offer Price value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Best Offer Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Best Offer Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Set Best Offer Price to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Best Offer Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}
using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Upper Auction Collar Price: Indicates the price of the Upper Auction Collar Threshold
    /// </summary>

    public struct UpperAuctionCollarPrice
    {
        /// <summary>
        ///  Decimal place factor for Upper Auction Collar Price
        /// </summary>
        public const uint Factor = 10000;

        /// <summary>
        ///  Size of Upper Auction Collar Price in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Upper Auction Collar Price value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Upper Auction Collar Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying) / Factor;

        /// <summary>
        ///  Write Upper Auction Collar Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value) * Factor;

        /// <summary>
        ///  Upper Auction Collar Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}
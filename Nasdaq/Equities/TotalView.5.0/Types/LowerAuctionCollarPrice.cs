using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Lower Auction Collar Price: Indicates the price of the Lower Auction Collar Threshold
    /// </summary>

    public struct LowerAuctionCollarPrice
    {
        /// <summary>
        ///  Decimal place factor for Lower Auction Collar Price
        /// </summary>
        public const uint Factor = 10000;

        /// <summary>
        ///  Size of Lower Auction Collar Price in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Lower Auction Collar Price value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Lower Auction Collar Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying) / Factor;

        /// <summary>
        ///  Write Lower Auction Collar Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value) * Factor;

        /// <summary>
        ///  Set Lower Auction Collar Price to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Lower Auction Collar Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}
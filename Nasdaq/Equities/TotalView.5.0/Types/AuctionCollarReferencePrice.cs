using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Auction Collar Reference Price: Reference price used to set the Auction Collars
    /// </summary>

    public struct AuctionCollarReferencePrice
    {
        /// <summary>
        ///  Decimal place factor for Auction Collar Reference Price
        /// </summary>
        public const uint Factor = 10000;

        /// <summary>
        ///  Size of Auction Collar Reference Price in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Auction Collar Reference Price value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Auction Collar Reference Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying) / Factor;

        /// <summary>
        ///  Write Auction Collar Reference Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value) * Factor;

        /// <summary>
        ///  Auction Collar Reference Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}
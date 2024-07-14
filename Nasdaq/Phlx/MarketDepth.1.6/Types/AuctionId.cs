using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Auction Id: Uniquely identifies the Auction for the trading day.
    /// </summary>

    public struct AuctionId
    {
        /// <summary>
        ///  Size of Auction Id in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Auction Id value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Auction Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Auction Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Auction Id as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Auction Id: CUBE Auction identifier supplied by Pillar Market Data to allow GTX responses to target specific CUBE auctions. If provided on non-GTX responses, the order will be rejected.
    /// </summary>

    public struct AuctionId
    {
        /// <summary>
        ///  Size of Auction Id in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Auction Id value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Auction Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying;

        /// <summary>
        ///  Write Auction Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value;

        /// <summary>
        ///  Auction Id as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}
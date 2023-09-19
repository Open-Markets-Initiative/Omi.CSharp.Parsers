using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Auction Id: CUBE Auction identifier supplied by Pillar Market Data to allow GTX responses to target specific CUBE auctions. If provided on non-GTX responses, the order will be rejected.
    /// </summary>

    public unsafe struct AuctionId
    {
        /// <summary>
        ///  Size of Auction Id in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Auction Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return (ulong)pointer; }
        }

        /// <summary>
        ///  Write Auction Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value; }
        }

        /// <summary>
        ///  Auction Id as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
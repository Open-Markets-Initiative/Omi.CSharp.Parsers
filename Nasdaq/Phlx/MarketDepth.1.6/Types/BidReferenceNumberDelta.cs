using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Bid Reference Number Delta: The bid reference number delta associated with the new quote.
    /// </summary>

    public unsafe struct BidReferenceNumberDelta
    {
        /// <summary>
        ///  Length of Bid Reference Number Delta in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Bid Reference Number Delta
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((uint)pointer); }
        }

        /// <summary>
        ///  Write Bid Reference Number Delta
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
        {
            fixed (byte* pointer = Bytes) { *(uint *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Bid Reference Number Delta as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
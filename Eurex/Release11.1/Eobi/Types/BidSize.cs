using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Bid Size
    /// </summary>

    public unsafe struct BidSize
    {
        /// <summary>
        ///  Decimal place factor for Bid Size
        /// </summary>
        public const ulong Factor = 10000;

        /// <summary>
        ///  Size of Bid Size in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Bid Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return ((ulong)pointer)/Factor; }
        }

        /// <summary>
        ///  Write Bid Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Bid Size as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
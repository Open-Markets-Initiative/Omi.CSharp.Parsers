using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Bid Px
    /// </summary>

    public unsafe struct BidPx
    {
        /// <summary>
        ///  Decimal place factor for Bid Px
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Size of Bid Px in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Bid Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return ((ulong)pointer)/Factor; }
        }

        /// <summary>
        ///  Write Bid Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Bid Px as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
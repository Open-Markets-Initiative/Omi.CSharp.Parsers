using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Bid Px
    /// </summary>

    public struct BidPx
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
        ///  Bid Px value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Bid Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Bid Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Bid Px as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}
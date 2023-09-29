using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Bid Size
    /// </summary>

    public struct BidSize
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
        ///  Bid Size value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Bid Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Bid Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Bid Size as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}
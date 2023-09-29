using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Offer Size
    /// </summary>

    public struct OfferSize
    {
        /// <summary>
        ///  Decimal place factor for Offer Size
        /// </summary>
        public const ulong Factor = 10000;

        /// <summary>
        ///  Size of Offer Size in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Offer Size value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Offer Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Offer Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Offer Size as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}
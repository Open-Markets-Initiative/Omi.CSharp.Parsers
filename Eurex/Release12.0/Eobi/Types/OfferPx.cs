using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Offer Px
    /// </summary>

    public struct OfferPx
    {
        /// <summary>
        ///  Decimal place factor for Offer Px
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Size of Offer Px in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Offer Px value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Offer Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Offer Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Offer Px as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}
using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Strike Price
    /// </summary>

    public struct StrikePrice
    {
        /// <summary>
        ///  Decimal place factor for Strike Price
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Size of Strike Price in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Strike Price value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Strike Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Strike Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Strike Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}
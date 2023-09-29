using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Prev Price
    /// </summary>

    public struct PrevPrice
    {
        /// <summary>
        ///  Decimal place factor for Prev Price
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Size of Prev Price in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Prev Price value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Prev Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Prev Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Prev Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}
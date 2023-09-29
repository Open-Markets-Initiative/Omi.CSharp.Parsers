using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  High Px
    /// </summary>

    public struct HighPx
    {
        /// <summary>
        ///  Decimal place factor for High Px
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Size of High Px in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  High Px value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read High Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write High Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value * Factor;

        /// <summary>
        ///  High Px as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}
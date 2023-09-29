using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Last Px
    /// </summary>

    public struct LastPx
    {
        /// <summary>
        ///  Decimal place factor for Last Px
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Size of Last Px in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Last Px value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Last Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Last Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Last Px as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}
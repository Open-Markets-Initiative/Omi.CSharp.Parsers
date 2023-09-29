using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Md Entry Px
    /// </summary>

    public struct MdEntryPx
    {
        /// <summary>
        ///  Decimal place factor for Md Entry Px
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Size of Md Entry Px in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Md Entry Px value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Md Entry Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Md Entry Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Md Entry Px as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}
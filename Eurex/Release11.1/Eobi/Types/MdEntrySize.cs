using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Md Entry Size
    /// </summary>

    public struct MdEntrySize
    {
        /// <summary>
        ///  Maximum value for Md Entry Size
        /// </summary>
        public const ulong Maximum = 922337203685477.5807;

        /// <summary>
        ///  Minimum value for Md Entry Size
        /// </summary>
        public const ulong Minimum = -922337203685477.5807;

        /// <summary>
        ///  Decimal place factor for Md Entry Size
        /// </summary>
        public const ulong Factor = 10000;

        /// <summary>
        ///  Size of Md Entry Size in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Md Entry Size value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Md Entry Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Md Entry Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Md Entry Size as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}
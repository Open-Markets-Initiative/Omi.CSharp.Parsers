using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Level 2: Denotes the MWCB Level 2 Value.
    /// </summary>

    public struct Level2
    {
        /// <summary>
        ///  Decimal place factor for Level 2
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Size of Level 2 in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Level 2 value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Level 2
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying) / Factor;

        /// <summary>
        ///  Write Level 2
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value) * Factor;

        /// <summary>
        ///  Level 2 as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}
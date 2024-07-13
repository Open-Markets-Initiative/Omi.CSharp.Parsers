using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Level 3: Denotes the MWCB Level 3 Value.
    /// </summary>

    public struct Level3
    {
        /// <summary>
        ///  Decimal place factor for Level 3
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Size of Level 3 in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Level 3 value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Level 3
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying) / Factor;

        /// <summary>
        ///  Write Level 3
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value) * Factor;

        /// <summary>
        ///  Set Level 3 to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Level 3 as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}
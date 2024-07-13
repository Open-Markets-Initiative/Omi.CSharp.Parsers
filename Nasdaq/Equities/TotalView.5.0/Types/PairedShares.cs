using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Paired Shares: The total number of shares that are eligible to be matched at the Current Reference Price.
    /// </summary>

    public struct PairedShares
    {
        /// <summary>
        ///  Size of Paired Shares in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Paired Shares value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Paired Shares
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Paired Shares
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Set Paired Shares to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Paired Shares as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}
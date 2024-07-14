using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Round Lot Size: Denotes the number of shares that represent a round lot for the issue
    /// </summary>

    public struct RoundLotSize
    {
        /// <summary>
        ///  Size of Round Lot Size in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Round Lot Size value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Round Lot Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Round Lot Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Round Lot Size as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}
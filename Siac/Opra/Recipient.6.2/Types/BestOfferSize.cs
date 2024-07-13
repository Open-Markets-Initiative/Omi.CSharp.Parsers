using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Best Offer Size: The Best Offer Size Identifies The Number Of Contracts Being Bought For An Option At The Best Offer Price
    /// </summary>

    public struct BestOfferSize
    {
        /// <summary>
        ///  Size of Best Offer Size in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Best Offer Size value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Best Offer Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Best Offer Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Set Best Offer Size to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Best Offer Size as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}
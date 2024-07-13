using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Offer Size: The Offer Size Identifies The Number Of Contracts For Sale For An Option At The Offer Price
    /// </summary>

    public struct OfferSize
    {
        /// <summary>
        ///  Size of Offer Size in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Offer Size value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Offer Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Offer Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Set Offer Size to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Offer Size as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}
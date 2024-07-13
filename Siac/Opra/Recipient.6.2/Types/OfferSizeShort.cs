using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Offer Size Short: The Offer Size Identifies The Number Of Contracts For Sale For An Option At The Offer Price
    /// </summary>

    public struct OfferSizeShort
    {
        /// <summary>
        ///  Size of Offer Size Short in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Offer Size Short value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Offer Size Short
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Offer Size Short
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Set Offer Size Short to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Offer Size Short as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}
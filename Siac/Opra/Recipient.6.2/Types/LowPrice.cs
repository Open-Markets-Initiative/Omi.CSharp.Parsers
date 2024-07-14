using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Low Price: Represents The Lowest Price Paid For An Option During The Trading Day
    /// </summary>

    public struct LowPrice
    {
        /// <summary>
        ///  Size of Low Price in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Low Price value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Low Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Low Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Low Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}
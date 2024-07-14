using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Increment Premium Price: Price increment for the option market.
    /// </summary>

    public struct IncrementPremiumPrice
    {
        /// <summary>
        ///  Size of Increment Premium Price in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Increment Premium Price value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Increment Premium Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Increment Premium Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Increment Premium Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}
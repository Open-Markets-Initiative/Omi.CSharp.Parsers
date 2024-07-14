using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Off Exchange Increment Price: Off exchange increment price.
    /// </summary>

    public struct OffExchangeIncrementPrice
    {
        /// <summary>
        ///  Size of Off Exchange Increment Price in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Off Exchange Increment Price value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Off Exchange Increment Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Off Exchange Increment Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Off Exchange Increment Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}
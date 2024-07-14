using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Last Price: Represents The Last Price Paid For An Option During The Trading Day
    /// </summary>

    public struct LastPrice
    {
        /// <summary>
        ///  Size of Last Price in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Last Price value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Last Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Last Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Last Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}
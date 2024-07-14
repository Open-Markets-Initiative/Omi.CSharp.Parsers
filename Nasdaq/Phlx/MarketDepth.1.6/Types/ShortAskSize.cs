using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Short Ask Size: The ask contracts of the new quote.
    /// </summary>

    public struct ShortAskSize
    {
        /// <summary>
        ///  Size of Short Ask Size in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Short Ask Size value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Short Ask Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Short Ask Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Short Ask Size as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}
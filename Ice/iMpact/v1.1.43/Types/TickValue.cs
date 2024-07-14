using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Tick Value: OrderPriceDenominator should be applied to get the real value.
    /// </summary>

    public struct TickValue
    {
        /// <summary>
        ///  Size of Tick Value in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Tick Value value
        /// </summary>
        public readonly long Value
            => Decode();

        /// <summary>
        ///  Read Tick Value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Tick Value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Tick Value as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Underlying;
    }
}
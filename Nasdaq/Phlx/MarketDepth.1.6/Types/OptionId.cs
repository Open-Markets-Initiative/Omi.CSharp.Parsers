using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Option Id: Option ID assigned daily, valid for trading day.
    /// </summary>

    public struct OptionId
    {
        /// <summary>
        ///  Size of Option Id in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Option Id value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Option Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Option Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Option Id as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}
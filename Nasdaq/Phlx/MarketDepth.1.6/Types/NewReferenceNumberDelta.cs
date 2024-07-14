using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  New Reference Number Delta: The new reference number delta associated with the new order.
    /// </summary>

    public struct NewReferenceNumberDelta
    {
        /// <summary>
        ///  Size of New Reference Number Delta in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  New Reference Number Delta value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read New Reference Number Delta
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write New Reference Number Delta
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  New Reference Number Delta as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}
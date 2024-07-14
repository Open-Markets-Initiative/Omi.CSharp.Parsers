using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Cancelled Contracts: The number of contracts to be removed from the display size of the order/quote as the result of a cancellation.
    /// </summary>

    public struct CancelledContracts
    {
        /// <summary>
        ///  Size of Cancelled Contracts in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Cancelled Contracts value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Cancelled Contracts
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Cancelled Contracts
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Cancelled Contracts as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}
using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Base Reference Number: The base reference number
    /// </summary>

    public struct BaseReferenceNumber
    {
        /// <summary>
        ///  Size of Base Reference Number in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Base Reference Number value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Base Reference Number
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Base Reference Number
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Base Reference Number as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}
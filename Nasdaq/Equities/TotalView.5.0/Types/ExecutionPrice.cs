using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Execution Price: The price at which the order execution occurred. Refer to Data Types for field processing notes.
    /// </summary>

    public struct ExecutionPrice
    {
        /// <summary>
        ///  Decimal place factor for Execution Price
        /// </summary>
        public const uint Factor = 10000;

        /// <summary>
        ///  Size of Execution Price in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Execution Price value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Execution Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying) / Factor;

        /// <summary>
        ///  Write Execution Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value) * Factor;

        /// <summary>
        ///  Execution Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}
using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Number Of Reference Number Deltas: The number of single side deletes in this block. Max possible value = 360
    /// </summary>

    public struct NumberOfReferenceNumberDeltas
    {
        /// <summary>
        ///  Size of Number Of Reference Number Deltas in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Number Of Reference Number Deltas value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Number Of Reference Number Deltas
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Number Of Reference Number Deltas
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Set Number Of Reference Number Deltas to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Number Of Reference Number Deltas as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}
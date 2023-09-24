using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Number Of Reference Number Deltas: The number of single side deletes in this block. Max possible value = 360
    /// </summary>

    public unsafe struct NumberOfReferenceNumberDeltas
    {
        /// <summary>
        ///  Length of Number Of Reference Number Deltas in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Number Of Reference Number Deltas
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((ushort)pointer); }
        }

        /// <summary>
        ///  Write Number Of Reference Number Deltas
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Number Of Reference Number Deltas as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Timestamp: Nanoseconds portion of the timestamp.
    /// </summary>

    public unsafe struct Timestamp
    {
        /// <summary>
        ///  Length of Timestamp in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Timestamp
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((uint)pointer); }
        }

        /// <summary>
        ///  Write Timestamp
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
        {
            fixed (byte* pointer = Bytes) { *(uint *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Timestamp as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
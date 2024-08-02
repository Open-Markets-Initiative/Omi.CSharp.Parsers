using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Timestamp: Nanoseconds since midnight.
    /// </summary>

    public unsafe struct Timestamp
    {
        /// <summary>
        ///  Size of Timestamp in bytes
        /// </summary>
        public const int Size = 6;

        /// <summary>
        ///  Timestamp value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Timestamp
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
        {
            ulong value = 0;
            fixed (byte* underlying = Underlying)

            // Read the 6 bytes and construct the ulong
            for (int i = 0; i < Size; i++)
            {
                value |= ((ulong)underlying[i]) << (8 * i);
            }

            // Reverse endianness of the 6-byte value
            value = BinaryPrimitives.ReverseEndianness(value << 16) >> 16;

            return value;
        }

        /// <summary>
        ///  Write Timestamp
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            value = BinaryPrimitives.ReverseEndianness(value << 16) >> 16;
            fixed (byte* underlying = Underlying)

            // Write the 6 bytes
            for (int i = 0; i < Size; i++)
            {
                underlying[i] = (byte)(value >> (8 * i));
            }
        }

        /// <summary>
        ///  Timestamp as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal fixed byte Underlying[Size];
    }
}
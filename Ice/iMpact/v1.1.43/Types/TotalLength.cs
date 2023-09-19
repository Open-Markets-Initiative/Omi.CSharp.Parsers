using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Total Length: The total length of the fragmented message.
    /// </summary>

    public unsafe struct TotalLength
    {
        /// <summary>
        ///  Length of Total Length in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Total Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((short)pointer); }
        }

        /// <summary>
        ///  Write Total Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(short value)
        {
            fixed (byte* pointer = Bytes) { *(short *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Total Length as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
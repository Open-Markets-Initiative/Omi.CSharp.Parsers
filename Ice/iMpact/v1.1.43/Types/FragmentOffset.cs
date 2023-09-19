using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Fragment Offset: The index of the byte where this fragment starts within the total length of the fragmented message.
    /// </summary>

    public unsafe struct FragmentOffset
    {
        /// <summary>
        ///  Length of Fragment Offset in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Fragment Offset
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((short)pointer); }
        }

        /// <summary>
        ///  Write Fragment Offset
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(short value)
        {
            fixed (byte* pointer = Bytes) { *(short *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Fragment Offset as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  End Year: 4 digit year
    /// </summary>

    public unsafe struct EndYear
    {
        /// <summary>
        ///  Length of End Year in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read End Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((short)pointer); }
        }

        /// <summary>
        ///  Write End Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(short value)
        {
            fixed (byte* pointer = Bytes) { *(short *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  End Year as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
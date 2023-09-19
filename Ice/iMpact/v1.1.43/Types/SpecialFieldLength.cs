using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Special Field Length: Length of this field
    /// </summary>

    public unsafe struct SpecialFieldLength
    {
        /// <summary>
        ///  Length of Special Field Length in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Read Special Field Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((ushort)pointer); }
        }

        /// <summary>
        ///  Write Special Field Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
        {
            fixed (byte* pointer = Bytes) { *(ushort *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Special Field Length as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
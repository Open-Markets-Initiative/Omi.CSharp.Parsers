using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Reserved: Reserved for future use
    /// </summary>

    public unsafe struct Reserved
    {
        /// <summary>
        ///  Length of Reserved in bytes
        /// </summary>
        public const int Size = 3;

        /// <summary>
        ///  Read Reserved
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fixed byte Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((fixed byte)pointer); }
        }

        /// <summary>
        ///  Write Reserved
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(fixed byte value)
        {
            fixed (byte* pointer = Bytes) { *(fixed byte *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Reserved as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
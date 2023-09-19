using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Lot Size: The lot size is minimum size of contracts in lots. It is multiplier to determine the total lots.
    /// </summary>

    public unsafe struct LotSize
    {
        /// <summary>
        ///  Length of Lot Size in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Lot Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((int)pointer); }
        }

        /// <summary>
        ///  Write Lot Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Lot Size as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
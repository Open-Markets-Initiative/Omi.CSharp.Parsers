using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Usd Price: Auctioneers price for the round in USD. Use 2 decimal places for USD Price.
    /// </summary>

    public unsafe struct UsdPrice
    {
        /// <summary>
        ///  Length of Usd Price in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Usd Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((long)pointer); }
        }

        /// <summary>
        ///  Write Usd Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Usd Price as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Min Price: Minimum Price. OrderPriceDenominator should be applied to this field.
    /// </summary>

    public unsafe struct MinPrice
    {
        /// <summary>
        ///  Length of Min Price in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Min Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((long)pointer); }
        }

        /// <summary>
        ///  Write Min Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Min Price as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
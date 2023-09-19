using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Pre Open Price: DealPriceDenominator for the market should be applied to get the real price.
    /// </summary>

    public unsafe struct PreOpenPrice
    {
        /// <summary>
        ///  Length of Pre Open Price in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Pre Open Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((long)pointer); }
        }

        /// <summary>
        ///  Write Pre Open Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Pre Open Price as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
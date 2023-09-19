using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Previous Day Settlement Price: SettlePriceDenominator for the market should be applied to get the real previous day settlement price.
    /// </summary>

    public unsafe struct PreviousDaySettlementPrice
    {
        /// <summary>
        ///  Length of Previous Day Settlement Price in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Previous Day Settlement Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((long)pointer); }
        }

        /// <summary>
        ///  Write Previous Day Settlement Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Previous Day Settlement Price as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
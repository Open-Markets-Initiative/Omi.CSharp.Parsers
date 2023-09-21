using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Bid Price: The display bid price of the new quote.  NOTE: When converted to a decimal format, this price is in fixed point format with 6 whole number places followed by 4 decimal digits.
    /// </summary>

    public unsafe struct BidPrice
    {
        /// <summary>
        ///  Size of Bid Price in bytes
        /// </summary>
        public const int Size = 4;


        /// <summary>
        ///  Decimal place factor for Bid Price
        /// </summary>
        public const int Factor = 10000;

        /// <summary>
        ///  Read Bid Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((int)pointer); }
        }

        /// <summary>
        ///  Write Bid Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Set Bid Price to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Bid Price as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
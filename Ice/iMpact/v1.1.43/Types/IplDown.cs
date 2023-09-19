using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Ipl Down: IPL lower bound. OrderPriceDenominator for the market should be applied to get the real price limit. >N/A when IPLHoldNotifyType = ‘E’
    /// </summary>

    public unsafe struct IplDown
    {
        /// <summary>
        ///  Length of Ipl Down in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Read Ipl Down
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((long)pointer); }
        }

        /// <summary>
        ///  Write Ipl Down
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
        {
            fixed (byte* pointer = Bytes) { *(long *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Ipl Down as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
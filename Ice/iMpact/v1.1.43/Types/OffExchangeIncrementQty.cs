using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Off Exchange Increment Qty: Off exchange increment qty. OffExchangeIncrementQtyDenominator should be applied to this field.
    /// </summary>

    public unsafe struct OffExchangeIncrementQty
    {
        /// <summary>
        ///  Length of Off Exchange Increment Qty in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Off Exchange Increment Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return BinaryPrimitives.ReverseEndianness((int)pointer); }
        }

        /// <summary>
        ///  Write Off Exchange Increment Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = BinaryPrimitives.ReverseEndianness(value); }
        }

        /// <summary>
        ///  Off Exchange Increment Qty as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}
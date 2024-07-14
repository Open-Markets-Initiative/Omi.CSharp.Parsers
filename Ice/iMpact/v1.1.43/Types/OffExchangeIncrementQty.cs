using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Off Exchange Increment Qty: Off exchange increment qty. OffExchangeIncrementQtyDenominator should be applied to this field.
    /// </summary>

    public struct OffExchangeIncrementQty
    {
        /// <summary>
        ///  Size of Off Exchange Increment Qty in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Off Exchange Increment Qty value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Off Exchange Increment Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Off Exchange Increment Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Off Exchange Increment Qty as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}
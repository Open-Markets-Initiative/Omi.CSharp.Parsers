using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Agg Offer Qty: Aggregate offer quantity
    /// </summary>

    public struct AggOfferQty
    {
        /// <summary>
        ///  Size of Agg Offer Qty in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Agg Offer Qty value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Agg Offer Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Agg Offer Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Set Agg Offer Qty to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Agg Offer Qty as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}
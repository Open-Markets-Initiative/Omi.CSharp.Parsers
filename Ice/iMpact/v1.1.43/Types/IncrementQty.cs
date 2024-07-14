using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Increment Qty: Minimum increment quantity for this market
    /// </summary>

    public struct IncrementQty
    {
        /// <summary>
        ///  Size of Increment Qty in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Increment Qty value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Increment Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Increment Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Increment Qty as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}
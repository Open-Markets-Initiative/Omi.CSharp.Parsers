using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Unit Quantity: The quantity in unit of measurement per lot. For example, it is 1000 barrels per lot for Brent.
    /// </summary>

    public struct UnitQuantity
    {
        /// <summary>
        ///  Size of Unit Quantity in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Unit Quantity value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Unit Quantity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Unit Quantity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Set Unit Quantity to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Unit Quantity as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}
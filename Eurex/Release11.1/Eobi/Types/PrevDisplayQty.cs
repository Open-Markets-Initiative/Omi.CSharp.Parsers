using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Prev Display Qty
    /// </summary>

    public struct PrevDisplayQty
    {
        /// <summary>
        ///  Decimal place factor for Prev Display Qty
        /// </summary>
        public const ulong Factor = 10000;

        /// <summary>
        ///  Size of Prev Display Qty in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Prev Display Qty value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Prev Display Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Prev Display Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Prev Display Qty as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}
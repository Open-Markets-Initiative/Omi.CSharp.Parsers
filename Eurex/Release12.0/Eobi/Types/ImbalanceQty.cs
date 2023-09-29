using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Imbalance Qty
    /// </summary>

    public struct ImbalanceQty
    {
        /// <summary>
        ///  Decimal place factor for Imbalance Qty
        /// </summary>
        public const ulong Factor = 10000;

        /// <summary>
        ///  Size of Imbalance Qty in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Imbalance Qty value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Imbalance Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Imbalance Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Imbalance Qty as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}
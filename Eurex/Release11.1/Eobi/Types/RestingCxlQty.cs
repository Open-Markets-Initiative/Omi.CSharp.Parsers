using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Resting Cxl Qty
    /// </summary>

    public struct RestingCxlQty
    {
        /// <summary>
        ///  Maximum value for Resting Cxl Qty
        /// </summary>
        public const ulong Maximum = 922337203685477.5807;

        /// <summary>
        ///  Minimum value for Resting Cxl Qty
        /// </summary>
        public const ulong Minimum = -922337203685477.5807;

        /// <summary>
        ///  Decimal place factor for Resting Cxl Qty
        /// </summary>
        public const ulong Factor = 10000;

        /// <summary>
        ///  Size of Resting Cxl Qty in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Resting Cxl Qty value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Resting Cxl Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Resting Cxl Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Resting Cxl Qty as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}
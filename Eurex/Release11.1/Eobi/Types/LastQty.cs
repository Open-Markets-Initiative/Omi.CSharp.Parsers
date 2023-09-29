using System.Runtime.CompilerServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Last Qty
    /// </summary>

    public struct LastQty
    {
        /// <summary>
        ///  Decimal place factor for Last Qty
        /// </summary>
        public const ulong Factor = 10000;

        /// <summary>
        ///  Size of Last Qty in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Last Qty value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Last Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Last Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Last Qty as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}
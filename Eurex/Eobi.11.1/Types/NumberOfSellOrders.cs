using System;
using System.Runtime.CompilerServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Number Of Sell Orders:
    /// </summary>

    public unsafe struct NumberOfSellOrders
    {
        /// <summary>
        ///  Length of Number Of Sell Orders in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Number Of Sell Orders
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
            => Value;

        /// <summary>
        ///  Encode Number Of Sell Orders
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Value;
    }
}
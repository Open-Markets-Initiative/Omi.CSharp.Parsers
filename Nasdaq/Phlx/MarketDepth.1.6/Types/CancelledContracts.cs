using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Cancelled Contracts: The number of contracts to be removed from the display size of the order/quote as the result of a cancellation.
    /// </summary>

    public unsafe struct CancelledContracts
    {
        /// <summary>
        ///  Length of Cancelled Contracts in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Cancelled Contracts
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Cancelled Contracts
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Value;
    }
}
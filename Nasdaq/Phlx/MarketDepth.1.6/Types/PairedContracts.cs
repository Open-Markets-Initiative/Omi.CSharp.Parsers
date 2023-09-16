using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Paired Contracts: The total number of contracts that are eligible to be matched at the Current Reference Price. Zero for Order Exposure notifications.
    /// </summary>

    public unsafe struct PairedContracts
    {
        /// <summary>
        ///  Length of Paired Contracts in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Paired Contracts
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Paired Contracts
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
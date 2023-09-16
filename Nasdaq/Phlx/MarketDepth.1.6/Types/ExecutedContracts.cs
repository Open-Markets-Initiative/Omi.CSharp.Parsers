using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Executed Contracts: The number of contracts executed.
    /// </summary>

    public unsafe struct ExecutedContracts
    {
        /// <summary>
        ///  Length of Executed Contracts in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Executed Contracts
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Executed Contracts
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
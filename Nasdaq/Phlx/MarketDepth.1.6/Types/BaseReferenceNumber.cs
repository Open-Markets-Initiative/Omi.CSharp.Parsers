using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Base Reference Number: The base reference number
    /// </summary>

    public unsafe struct BaseReferenceNumber
    {
        /// <summary>
        ///  Length of Base Reference Number in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Base Reference Number
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
            => Value;

        /// <summary>
        ///  Encode Base Reference Number
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Value;
    }
}
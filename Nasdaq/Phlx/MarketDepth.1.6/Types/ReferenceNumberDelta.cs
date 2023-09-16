using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Reference Number Delta: The order/quote reference number delta associated with the executed order.
    /// </summary>

    public unsafe struct ReferenceNumberDelta
    {
        /// <summary>
        ///  Length of Reference Number Delta in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Reference Number Delta
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Reference Number Delta
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
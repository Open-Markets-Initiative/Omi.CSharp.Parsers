using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Ask Reference Number Delta: The ask reference number delta associated with the new quote
    /// </summary>

    public unsafe struct AskReferenceNumberDelta
    {
        /// <summary>
        ///  Length of Ask Reference Number Delta in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Ask Reference Number Delta
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Ask Reference Number Delta
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
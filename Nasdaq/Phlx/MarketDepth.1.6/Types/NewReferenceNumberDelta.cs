using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  New Reference Number Delta: The new reference number delta associated with the new order.
    /// </summary>

    public unsafe struct NewReferenceNumberDelta
    {
        /// <summary>
        ///  Length of New Reference Number Delta in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read New Reference Number Delta
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode New Reference Number Delta
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
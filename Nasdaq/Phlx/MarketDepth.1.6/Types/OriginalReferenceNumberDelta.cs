using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Original Reference Number Delta: The original reference number delta associated with the order being replaced.
    /// </summary>

    public unsafe struct OriginalReferenceNumberDelta
    {
        /// <summary>
        ///  Length of Original Reference Number Delta in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Original Reference Number Delta
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Original Reference Number Delta
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
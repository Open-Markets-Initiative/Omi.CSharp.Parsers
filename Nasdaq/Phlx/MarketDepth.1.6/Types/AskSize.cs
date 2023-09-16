using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Ask Size: The ask contracts of the new quote.
    /// </summary>

    public unsafe struct AskSize
    {
        /// <summary>
        ///  Length of Ask Size in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Ask Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Ask Size
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
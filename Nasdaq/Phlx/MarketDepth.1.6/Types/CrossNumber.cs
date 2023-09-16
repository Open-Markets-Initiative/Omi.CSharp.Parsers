using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Cross Number: Trade Group Id. Ties together all trades of a given atomic transaction in the matching engine.
    /// </summary>

    public unsafe struct CrossNumber
    {
        /// <summary>
        ///  Length of Cross Number in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Cross Number
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Cross Number
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
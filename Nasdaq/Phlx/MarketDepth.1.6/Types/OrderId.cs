using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Order Id: PHLX assigned order ID.
    /// </summary>

    public unsafe struct OrderId
    {
        /// <summary>
        ///  Length of Order Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Order Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Order Id
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
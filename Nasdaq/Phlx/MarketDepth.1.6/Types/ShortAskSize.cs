using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Short Ask Size: The ask contracts of the new quote.
    /// </summary>

    public unsafe struct ShortAskSize
    {
        /// <summary>
        ///  Length of Short Ask Size in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Short Ask Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
            => Value;

        /// <summary>
        ///  Encode Short Ask Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Value;
    }
}
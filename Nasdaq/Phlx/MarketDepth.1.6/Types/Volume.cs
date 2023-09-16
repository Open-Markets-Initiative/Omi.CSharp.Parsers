using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Volume: The total number of contracts of the new order being added to the book.
    /// </summary>

    public unsafe struct Volume
    {
        /// <summary>
        ///  Length of Volume in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Volume
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Volume
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
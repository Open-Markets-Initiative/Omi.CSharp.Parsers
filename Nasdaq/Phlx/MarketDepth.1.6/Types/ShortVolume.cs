using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Short Volume: The total number of contracts of the new order being added to the book.
    /// </summary>

    public unsafe struct ShortVolume
    {
        /// <summary>
        ///  Length of Short Volume in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Short Volume
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
            => Value;

        /// <summary>
        ///  Encode Short Volume
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
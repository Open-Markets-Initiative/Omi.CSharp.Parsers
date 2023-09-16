using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Option Id: Option ID assigned daily, valid for trading day.
    /// </summary>

    public unsafe struct OptionId
    {
        /// <summary>
        ///  Length of Option Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Option Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Option Id
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
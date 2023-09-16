using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Reserved: Reserved for future use
    /// </summary>

    public unsafe struct Reserved
    {
        /// <summary>
        ///  Length of Reserved in bytes
        /// </summary>
        public const int Length = 3;

        /// <summary>
        ///  Read Reserved
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fixed byte Decode()
            => Value;

        /// <summary>
        ///  Encode Reserved
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(fixed byte value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal fixed byte Value;
    }
}
using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Leg Underlying Market Id: Futures market id of the underlying futures market
    /// </summary>

    public unsafe struct LegUnderlyingMarketId
    {
        /// <summary>
        ///  Length of Leg Underlying Market Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Leg Underlying Market Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Leg Underlying Market Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Value;
    }
}
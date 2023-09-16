using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Hedge Market Id: Market ID for the corresponding hedge market.
    /// </summary>

    public unsafe struct HedgeMarketId
    {
        /// <summary>
        ///  Length of Hedge Market Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Hedge Market Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Hedge Market Id
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
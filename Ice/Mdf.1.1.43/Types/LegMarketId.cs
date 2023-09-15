using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Leg Market Id: Market Id of the futures leg
    /// </summary>

    public unsafe struct LegMarketId
    {
        /// <summary>
        ///  Length of Leg Market Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Leg Market Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Leg Market Id
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
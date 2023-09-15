using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Underlying Market Id: Unique identifier of the underlying market
    /// </summary>

    public unsafe struct UnderlyingMarketId
    {
        /// <summary>
        ///  Length of Underlying Market Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Underlying Market Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Underlying Market Id
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
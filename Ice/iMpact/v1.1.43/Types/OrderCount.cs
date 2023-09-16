using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Order Count: Number of all orders at the price level
    /// </summary>

    public unsafe struct OrderCount
    {
        /// <summary>
        ///  Length of Order Count in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Order Count
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Order Count
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(short value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal short Value;
    }
}
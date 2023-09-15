using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Last Trade Quantity:
    /// </summary>

    public unsafe struct LastTradeQuantity
    {
        /// <summary>
        ///  Length of Last Trade Quantity in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Last Trade Quantity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Last Trade Quantity
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
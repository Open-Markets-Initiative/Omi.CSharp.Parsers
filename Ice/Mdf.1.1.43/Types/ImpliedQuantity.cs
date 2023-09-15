using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Implied Quantity: Quantity that were implied
    /// </summary>

    public unsafe struct ImpliedQuantity
    {
        /// <summary>
        ///  Length of Implied Quantity in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Implied Quantity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Implied Quantity
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
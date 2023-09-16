using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Unit Quantity: The quantity in unit of measurement per lot. For example, it is 1000 barrels per lot for Brent.
    /// </summary>

    public unsafe struct UnitQuantity
    {
        /// <summary>
        ///  Length of Unit Quantity in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Unit Quantity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Unit Quantity
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
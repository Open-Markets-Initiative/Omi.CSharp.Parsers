using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Quantity:
    /// </summary>

    public unsafe struct Quantity
    {
        /// <summary>
        ///  Length of Quantity in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Quantity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Quantity
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
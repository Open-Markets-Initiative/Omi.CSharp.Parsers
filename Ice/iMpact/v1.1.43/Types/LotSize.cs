using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Lot Size: The lot size is minimum size of contracts in lots. It is multiplier to determine the total lots.
    /// </summary>

    public unsafe struct LotSize
    {
        /// <summary>
        ///  Length of Lot Size in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Lot Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Lot Size
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
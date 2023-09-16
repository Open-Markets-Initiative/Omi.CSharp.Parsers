using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Leg Ratio Qty Numerator: Leg Ratio Qty Numerator
    /// </summary>

    public unsafe struct LegRatioQtyNumerator
    {
        /// <summary>
        ///  Length of Leg Ratio Qty Numerator in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Leg Ratio Qty Numerator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Leg Ratio Qty Numerator
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
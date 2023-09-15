using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Leg Ratio Price Numerator: Leg Ratio Price Numerator
    /// </summary>

    public unsafe struct LegRatioPriceNumerator
    {
        /// <summary>
        ///  Length of Leg Ratio Price Numerator in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Leg Ratio Price Numerator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Leg Ratio Price Numerator
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
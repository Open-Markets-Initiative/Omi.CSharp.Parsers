using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Leg Ratio Price Denominator: Leg Ratio Price Denominator
    /// </summary>

    public unsafe struct LegRatioPriceDenominator
    {
        /// <summary>
        ///  Length of Leg Ratio Price Denominator in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Leg Ratio Price Denominator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Leg Ratio Price Denominator
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
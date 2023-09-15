using System;
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Usd Calculation 3: Integer US Dollar calculation.  For the following RiskControlTypes – will be populated with the
    /// </summary>

    public unsafe struct UsdCalculation3
    {
        /// <summary>
        ///  Length of Usd Calculation 3 in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Usd Calculation 3
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Usd Calculation 3
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(long value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal long Value;
    }
}
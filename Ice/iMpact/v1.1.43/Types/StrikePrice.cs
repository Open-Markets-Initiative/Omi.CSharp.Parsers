using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Strike Price: Strike Price of the option. Used in conjunction with the NumDecimalsStrikePrice. This is often different from the premium price decimals.
    /// </summary>

    public unsafe struct StrikePrice
    {
        /// <summary>
        ///  Length of Strike Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Strike Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Decode()
            => Value;

        /// <summary>
        ///  Encode Strike Price
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
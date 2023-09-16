using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Leg Ratio Obsolete: Number of futures contracts per increment quantity.
    /// </summary>

    public unsafe struct LegRatioObsolete
    {
        /// <summary>
        ///  Length of Leg Ratio Obsolete in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Leg Ratio Obsolete
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Leg Ratio Obsolete
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(short value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal short Value;
    }
}
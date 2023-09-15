using System;
using System.Runtime.CompilerServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Min Trade Vol: The minimum trading volume for a security
    /// </summary>

    public unsafe struct MinTradeVol
    {
        /// <summary>
        ///  Fix Tag for Min Trade Vol
        /// </summary>
        public const ushort FixTag = 562;

        /// <summary>
        ///  Length of Min Trade Vol in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Min Trade Vol
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Min Trade Vol
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Value;
    }
}
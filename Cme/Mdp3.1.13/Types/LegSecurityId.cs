using System;
using System.Runtime.CompilerServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Leg Security Id: Leg Security ID
    /// </summary>

    public unsafe struct LegSecurityId
    {
        /// <summary>
        ///  Fix Tag for Leg Security Id
        /// </summary>
        public const ushort FixTag = 602;

        /// <summary>
        ///  Length of Leg Security Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Leg Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Leg Security Id
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
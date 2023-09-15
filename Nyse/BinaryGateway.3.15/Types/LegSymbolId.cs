using System;
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Leg Symbol Id: Identification number assigned to the security.
    /// </summary>

    public unsafe struct LegSymbolId
    {
        /// <summary>
        ///  Length of Leg Symbol Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Leg Symbol Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Leg Symbol Id
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
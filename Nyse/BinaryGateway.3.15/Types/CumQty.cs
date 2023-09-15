using System;
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Cum Qty: 1 - 999,999
    /// </summary>

    public unsafe struct CumQty
    {
        /// <summary>
        ///  Length of Cum Qty in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Cum Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Cum Qty
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
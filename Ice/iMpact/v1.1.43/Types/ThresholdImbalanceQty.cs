using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Threshold Imbalance Qty:
    /// </summary>

    public unsafe struct ThresholdImbalanceQty
    {
        /// <summary>
        ///  Length of Threshold Imbalance Qty in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Threshold Imbalance Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Threshold Imbalance Qty
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
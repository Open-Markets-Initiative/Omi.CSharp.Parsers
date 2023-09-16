using System;
using System.Runtime.CompilerServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Number Of Reference Number Deltas: The number of single side deletes in this block. Max possible value = 360
    /// </summary>

    public unsafe struct NumberOfReferenceNumberDeltas
    {
        /// <summary>
        ///  Length of Number Of Reference Number Deltas in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Number Of Reference Number Deltas
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
            => Value;

        /// <summary>
        ///  Encode Number Of Reference Number Deltas
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Value;
    }
}
using System;
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Count Calculation: Integer count.
    /// </summary>

    public unsafe struct CountCalculation
    {
        /// <summary>
        ///  Length of Count Calculation in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Count Calculation
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Count Calculation
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
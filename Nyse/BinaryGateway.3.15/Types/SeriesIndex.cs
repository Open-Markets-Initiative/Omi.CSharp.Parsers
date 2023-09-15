using System;
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Series Index: Options series index
    /// </summary>

    public unsafe struct SeriesIndex
    {
        /// <summary>
        ///  Length of Series Index in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Series Index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
            => Value;

        /// <summary>
        ///  Encode Series Index
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
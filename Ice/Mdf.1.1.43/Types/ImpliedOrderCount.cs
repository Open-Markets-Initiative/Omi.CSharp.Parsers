using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Implied Order Count: Number of implied orders at the price level
    /// </summary>

    public unsafe struct ImpliedOrderCount
    {
        /// <summary>
        ///  Length of Implied Order Count in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Implied Order Count
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Implied Order Count
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
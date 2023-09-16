using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Strip Id: StripID
    /// </summary>

    public unsafe struct StripId
    {
        /// <summary>
        ///  Length of Strip Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Read Strip Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
            => Value;

        /// <summary>
        ///  Encode Strip Id
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
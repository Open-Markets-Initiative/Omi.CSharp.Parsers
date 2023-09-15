using System;
using System.Runtime.CompilerServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Body Len:
    /// </summary>

    public unsafe struct BodyLen
    {
        /// <summary>
        ///  Length of Body Len in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Body Len
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
            => Value;

        /// <summary>
        ///  Encode Body Len
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
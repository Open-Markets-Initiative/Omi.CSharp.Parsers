using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Begin Day:
    /// </summary>

    public unsafe struct BeginDay
    {
        /// <summary>
        ///  Length of Begin Day in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Begin Day
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Begin Day
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
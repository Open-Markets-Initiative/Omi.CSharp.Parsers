using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Begin Year: 4 digit year
    /// </summary>

    public unsafe struct BeginYear
    {
        /// <summary>
        ///  Length of Begin Year in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Begin Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Begin Year
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
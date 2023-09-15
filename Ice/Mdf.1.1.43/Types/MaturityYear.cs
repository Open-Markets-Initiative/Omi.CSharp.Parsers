using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Maturity Year: 4 digit year
    /// </summary>

    public unsafe struct MaturityYear
    {
        /// <summary>
        ///  Length of Maturity Year in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Maturity Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Maturity Year
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
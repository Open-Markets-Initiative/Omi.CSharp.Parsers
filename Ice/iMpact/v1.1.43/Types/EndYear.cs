using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  End Year: 4 digit year
    /// </summary>

    public unsafe struct EndYear
    {
        /// <summary>
        ///  Length of End Year in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read End Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode End Year
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
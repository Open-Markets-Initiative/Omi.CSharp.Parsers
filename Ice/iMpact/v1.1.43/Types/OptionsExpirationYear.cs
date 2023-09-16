using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Options Expiration Year: 4 digit year
    /// </summary>

    public unsafe struct OptionsExpirationYear
    {
        /// <summary>
        ///  Length of Options Expiration Year in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Options Expiration Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Options Expiration Year
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
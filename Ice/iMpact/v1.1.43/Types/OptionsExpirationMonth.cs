using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Options Expiration Month: Month Range
    /// </summary>

    public unsafe struct OptionsExpirationMonth
    {
        /// <summary>
        ///  Length of Options Expiration Month in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Options Expiration Month
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Options Expiration Month
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
using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Options Expiration Day: Day of the month
    /// </summary>

    public unsafe struct OptionsExpirationDay
    {
        /// <summary>
        ///  Length of Options Expiration Day in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Options Expiration Day
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Options Expiration Day
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
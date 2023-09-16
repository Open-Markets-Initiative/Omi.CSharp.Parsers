using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Old Strip Id: Not used. Kept here for backward compatibility. Client should use the new 4-byte StripID field.
    /// </summary>

    public unsafe struct OldStripId
    {
        /// <summary>
        ///  Length of Old Strip Id in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Old Strip Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short Decode()
            => Value;

        /// <summary>
        ///  Encode Old Strip Id
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
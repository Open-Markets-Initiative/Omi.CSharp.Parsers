using System;
using System.Runtime.CompilerServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Broken Date Guid: External unique broken date Instrument ID
    /// </summary>

    public unsafe struct BrokenDateGuid
    {
        /// <summary>
        ///  Fix Tag for Broken Date Guid
        /// </summary>
        public const ushort FixTag = 39031;

        /// <summary>
        ///  Length of Broken Date Guid in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Broken Date Guid
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
            => Value;

        /// <summary>
        ///  Encode Broken Date Guid
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Value;
    }
}
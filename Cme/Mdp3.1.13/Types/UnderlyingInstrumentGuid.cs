using System;
using System.Runtime.CompilerServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Underlying Instrument Guid: Underlying Instrument GUID. Collateral security identifier in REF Data API services
    /// </summary>

    public unsafe struct UnderlyingInstrumentGuid
    {
        /// <summary>
        ///  Fix Tag for Underlying Instrument Guid
        /// </summary>
        public const ushort FixTag = 37519;

        /// <summary>
        ///  Length of Underlying Instrument Guid in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Underlying Instrument Guid
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
            => Value;

        /// <summary>
        ///  Encode Underlying Instrument Guid
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
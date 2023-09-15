using System;
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Ref Cl Ord Id: Unique ID of the message as assigned by the firm.
    /// </summary>

    public unsafe struct RefClOrdId
    {
        /// <summary>
        ///  Length of Ref Cl Ord Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Ref Cl Ord Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
            => Value;

        /// <summary>
        ///  Encode Ref Cl Ord Id
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
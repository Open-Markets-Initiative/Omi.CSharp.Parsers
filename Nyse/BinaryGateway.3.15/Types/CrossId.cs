using System;
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Cross Id: Unique ID of the Cross as assigned by the firm.
    /// </summary>

    public unsafe struct CrossId
    {
        /// <summary>
        ///  Length of Cross Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Cross Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
            => Value;

        /// <summary>
        ///  Encode Cross Id
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